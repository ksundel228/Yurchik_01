using System;
using System.IO;

/// <summary>
/// Главный класс программы, выполняющий операции с файловой системой.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет сканирование дисков, создание каталогов, копирование и изменение атрибутов файлов.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Вывод списка всех файлов на локальных дисках (с обработкой ошибок доступа).
            /// </summary>
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Файлы на диске {drive.Name}:");

                    try
                    {
                        foreach (string file in Directory.GetFiles(drive.Name, "*.*", SearchOption.TopDirectoryOnly))
                        {
                            Console.WriteLine(file);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine($"Нет доступа к некоторым папкам на {drive.Name}");
                    }
                }
            }

            /// <summary>
            /// Создание каталога Exmple_36tp на диске D.
            /// </summary>
            string targetDirectory = @"D:\3 курс\Практика C#\Day19\zadanie_16\Exmple_36tp";
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
                Console.WriteLine($"Каталог {targetDirectory} создан.");
            }

            /// <summary>
            /// Копирование 3 разных файлов из другого каталога.
            /// </summary>
            string sourceDirectory = @"C:\SourceFiles"; // Укажите свою папку
            if (!Directory.Exists(sourceDirectory))
            {
                Console.WriteLine($"Каталог {sourceDirectory} не найден!");
                return;
            }

            string[] files = Directory.GetFiles(sourceDirectory).Take(3).ToArray();
            if (files.Length == 0)
            {
                Console.WriteLine("Нет файлов для копирования!");
                return;
            }

            foreach (string file in files)
            {
                string destFile = Path.Combine(targetDirectory, Path.GetFileName(file));
                File.Copy(file, destFile, true);
                Console.WriteLine($"Скопирован: {file} -> {destFile}");
            }

            /// <summary>
            /// Изменение атрибутов файлов на "Скрытый".
            /// </summary>
            foreach (string file in Directory.GetFiles(targetDirectory))
            {
                File.SetAttributes(file, FileAttributes.Hidden);
                Console.WriteLine($"Файл {file} стал скрытым.");
            }

            /// <summary>
            /// Создание файлов-ссылок вместо скрытых файлов.
            /// </summary>
            string shortcutsDir = Path.Combine(targetDirectory, "Shortcuts");
            Directory.CreateDirectory(shortcutsDir);

            foreach (string file in Directory.GetFiles(targetDirectory))
            {
                string shortcutPath = Path.Combine(shortcutsDir, Path.GetFileName(file) + ".lnk");
                using (StreamWriter writer = new StreamWriter(shortcutPath))
                {
                    writer.WriteLine($"Ссылка на файл: {file}");
                }
                Console.WriteLine($"Создан файл-ссылка: {shortcutPath}");
            }

            /// <summary>
            /// Вывод сообщения о завершении выполнения операций.
            /// </summary>
            Console.WriteLine("Задание выполнено!");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка исключений при работе с файловой системой.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadLine();
    }
}

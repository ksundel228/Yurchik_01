using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // 1. Вывод списка всех файлов на локальных дисках (с обработкой ошибок доступа)
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

            // 2. Создание каталога Exmple_36tp на диске D
            string targetDirectory = @"D:\3 курс\Практика C#\Day16\zadanie_7\Exmple_36tp";
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
                Console.WriteLine($"Каталог {targetDirectory} создан.");
            }

            // 3. Копирование 3 разных файлов из другого каталога
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

            // 4. Изменение атрибутов файлов на "Скрытый"
            foreach (string file in Directory.GetFiles(targetDirectory))
            {
                File.SetAttributes(file, FileAttributes.Hidden);
                Console.WriteLine($"Файл {file} стал скрытым.");
            }

            // 5. Создание файлов-ссылок вместо скрытых файлов
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

            Console.WriteLine("Задание выполнено!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadLine();
    }
}

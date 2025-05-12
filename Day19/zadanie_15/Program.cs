using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы, выполняющий проверку решений студентов по эталонному файлу.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет проверку файлов студентов, сравнивает их решения с эталонным и записывает успешные результаты.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к папке с файлами студентов.
        /// </summary>
        string folderPath = @"D:\StudentSolutions"; 

        /// <summary>
        /// Путь к эталонному файлу с правильным решением.
        /// </summary>
        string outputFile = @"D:\StudentSolutions\output.txt"; 

        /// <summary>
        /// Путь к файлу, содержащему список студентов с успешными решениями.
        /// </summary>
        string resultFile = @"D:\StudentSolutions\results.txt"; 

        /// <summary>
        /// Проверяет существование папки, если её нет, создаёт новую.
        /// </summary>
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Папка StudentSolutions создана.");
        }

        /// <summary>
        /// Получает список всех файлов студентов.
        /// </summary>
        string[] studentFiles = Directory.GetFiles(folderPath, "student*.txt");

        if (studentFiles.Length == 0)
        {
            Console.WriteLine("В папке нет файлов студентов!");
            return;
        }

        /// <summary>
        /// Проверяет существование эталонного файла.
        /// </summary>
        if (!File.Exists(outputFile))
        {
            Console.WriteLine("Файл output.txt отсутствует!");
            return;
        }

        /// <summary>
        /// Считывает эталонный результат, пропуская первую строку с заголовком.
        /// </summary>
        string[] outputLines = File.ReadAllLines(outputFile).Skip(1).Select(line => line.Trim()).ToArray();

        /// <summary>
        /// Открывает файл results.txt для записи успешных решений.
        /// </summary>
        using (StreamWriter writer = new StreamWriter(resultFile))
        {
            foreach (string file in studentFiles)
            {
                /// <summary>
                /// Читает содержимое файла студента и обрабатывает строки.
                /// </summary>
                string[] studentLines = File.ReadAllLines(file).Select(line => line.Trim()).ToArray();

                /// <summary>
                /// Фамилия студента, указанная в первой строке.
                /// </summary>
                string studentName = studentLines[0]; 

                /// <summary>
                /// Решение студента, без имени.
                /// </summary>
                string[] studentSolution = studentLines.Skip(1).ToArray(); 

                /// <summary>
                /// Сравнивает решение студента с эталонным и записывает фамилию при совпадении.
                /// </summary>
                if (outputLines.SequenceEqual(studentSolution))
                {
                    writer.WriteLine(studentName);
                }
            }
        }

        /// <summary>
        /// Выводит сообщение о завершении формирования файла результатов.
        /// </summary>
        Console.WriteLine("Файл results.txt сформирован.");
    }
}

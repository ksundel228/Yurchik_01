using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string folderPath = @"D:\StudentSolutions"; // Папка с файлами студентов
        string outputFile = @"D:\StudentSolutions\output.txt"; // Эталонный файл
        string resultFile = @"D:\StudentSolutions\results.txt"; // Файл с успешными решениями

        // Проверяем, существует ли папка, если нет — создаем её
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Папка StudentSolutions создана.");
        }

        // Получаем список всех файлов студентов
        string[] studentFiles = Directory.GetFiles(folderPath, "student*.txt");

        if (studentFiles.Length == 0)
        {
            Console.WriteLine("В папке нет файлов студентов!");
            return;
        }

        // Проверяем существование файла output.txt
        if (!File.Exists(outputFile))
        {
            Console.WriteLine("Файл output.txt отсутствует!");
            return;
        }

        // Считываем эталонный результат (без фамилии)
        string[] outputLines = File.ReadAllLines(outputFile).Skip(1).Select(line => line.Trim()).ToArray();

        using (StreamWriter writer = new StreamWriter(resultFile))
        {
            foreach (string file in studentFiles)
            {
                string[] studentLines = File.ReadAllLines(file).Select(line => line.Trim()).ToArray();
                string studentName = studentLines[0]; // Фамилия студента
                string[] studentSolution = studentLines.Skip(1).ToArray(); // Решение без имени

                // Проверка совпадения с эталоном
                if (outputLines.SequenceEqual(studentSolution))
                {
                    writer.WriteLine(studentName);
                }
            }
        }

        Console.WriteLine("Файл results.txt сформирован.");
    }
}


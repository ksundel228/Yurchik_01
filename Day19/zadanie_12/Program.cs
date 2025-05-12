using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы, выполняющий обработку текстового файла и операции над его содержимым.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет чтение, анализ и обработку строк из текстового файла.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к основному файлу с данными.
        /// </summary>
        string filePath = @"text.txt"; 

        /// <summary>
        /// Путь к новому файлу, в который будут записаны измененные данные.
        /// </summary>
        string newFilePath = @"new_text.txt"; 

        /// <summary>
        /// Записывает набор строк в основной файл.
        /// </summary>
        string[] lines = { "Первая строка", "Вторая строка", "Третья", "Четвёртая строка", "Последняя строка" };
        File.WriteAllLines(filePath, lines);

        /// <summary>
        /// Выводит содержимое файла на экран.
        /// </summary>
        Console.WriteLine("Содержимое файла:");
        foreach (string line in File.ReadLines(filePath))
            Console.WriteLine(line);

        /// <summary>
        /// Подсчитывает количество строк в файле.
        /// </summary>
        int lineCount = File.ReadLines(filePath).Count();
        Console.WriteLine($"\nКоличество строк: {lineCount}");

        /// <summary>
        /// Подсчитывает количество символов в каждой строке.
        /// </summary>
        Console.WriteLine("\nКоличество символов в каждой строке:");
        foreach (string line in File.ReadLines(filePath))
            Console.WriteLine($"{line}: {line.Length} символов");

        /// <summary>
        /// Удаляет последнюю строку и записывает результат в новый файл.
        /// </summary>
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Take(lineCount - 1));

        /// <summary>
        /// Выводит строки из файла в заданном диапазоне (например, со 2-й по 4-ю строку).
        /// </summary>
        int s1 = 2, s2 = 4;
        Console.WriteLine($"\nСтроки с {s1} по {s2}:");
        foreach (string line in File.ReadLines(filePath).Skip(s1 - 1).Take(s2 - s1 + 1))
            Console.WriteLine(line);

        /// <summary>
        /// Находит и выводит самую длинную строку в файле.
        /// </summary>
        string longestLine = File.ReadLines(filePath).OrderByDescending(line => line.Length).First();
        Console.WriteLine($"\nСамая длинная строка ({longestLine.Length} символов): {longestLine}");

        /// <summary>
        /// Выводит все строки, начинающиеся с заданной буквы.
        /// </summary>
        char firstLetter = 'П';
        Console.WriteLine($"\nСтроки, начинающиеся с '{firstLetter}':");
        foreach (string line in File.ReadLines(filePath).Where(line => line.StartsWith(firstLetter)))
            Console.WriteLine(line);

        /// <summary>
        /// Записывает строки в другой файл в обратном порядке.
        /// </summary>
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Reverse());
        Console.WriteLine($"\nФайл {newFilePath} теперь содержит строки в обратном порядке.");

        Console.ReadLine();
    }
}

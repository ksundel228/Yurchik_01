using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"text.txt"; // Основной файл
        string newFilePath = @"new_text.txt"; // Новый файл для сохранения изменений

        // Запись строк в файл
        string[] lines = { "Первая строка", "Вторая строка", "Третья", "Четвёртая строка", "Последняя строка" };
        File.WriteAllLines(filePath, lines);

        // a) Вывести весь файл на экран
        Console.WriteLine("Содержимое файла:");
        foreach (string line in File.ReadLines(filePath))
            Console.WriteLine(line);

        // b) Подсчитать количество строк
        int lineCount = File.ReadLines(filePath).Count();
        Console.WriteLine($"\nКоличество строк: {lineCount}");

        // c) Подсчитать количество символов в каждой строке
        Console.WriteLine("\nКоличество символов в каждой строке:");
        foreach (string line in File.ReadLines(filePath))
            Console.WriteLine($"{line}: {line.Length} символов");

        // d) Удалить последнюю строку и записать результат в новый файл
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Take(lineCount - 1));

        // e) Вывести на экран строки от s1 до s2 (пример: 2-я до 4-й строки)
        int s1 = 2, s2 = 4;
        Console.WriteLine($"\nСтроки с {s1} по {s2}:");
        foreach (string line in File.ReadLines(filePath).Skip(s1 - 1).Take(s2 - s1 + 1))
            Console.WriteLine(line);

        // f) Найти длину самой длинной строки и вывести ее
        string longestLine = File.ReadLines(filePath).OrderByDescending(line => line.Length).First();
        Console.WriteLine($"\nСамая длинная строка ({longestLine.Length} символов): {longestLine}");

        // g) Вывести все строки, начинающиеся с заданной буквы
        char firstLetter = 'П';
        Console.WriteLine($"\nСтроки, начинающиеся с '{firstLetter}':");
        foreach (string line in File.ReadLines(filePath).Where(line => line.StartsWith(firstLetter)))
            Console.WriteLine(line);

        // h) Записать строки в другой файл в обратном порядке
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Reverse());
        Console.WriteLine($"\nФайл {newFilePath} теперь содержит строки в обратном порядке.");

        Console.ReadLine();
    }
}

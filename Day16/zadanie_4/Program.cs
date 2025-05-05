using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFile = @"input.txt";   // Исходный файл
        string evenFile = @"even.txt";     // Файл для четных строк
        string oddFile = @"odd.txt";       // Файл для нечетных строк

        // Чтение всех строк из исходного файла
        string[] lines = File.ReadAllLines(inputFile);

        // Запись четных и нечетных строк в соответствующие файлы
        File.WriteAllLines(evenFile, lines.Where((line, index) => index % 2 == 1)); // Четные строки (индекс 1-based)
        File.WriteAllLines(oddFile, lines.Where((line, index) => index % 2 == 0)); // Нечетные строки

        Console.WriteLine("Разделение строк выполнено.");
        Console.ReadLine();
    }
}

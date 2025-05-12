using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы, выполняющий разделение строк из файла на четные и нечетные.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Считывает строки из исходного файла и разделяет их на четные и нечетные.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к исходному файлу, содержащему строки.
        /// </summary>
        string inputFile = @"input.txt";  

        /// <summary>
        /// Путь к файлу для записи четных строк.
        /// </summary>
        string evenFile = @"even.txt";     

        /// <summary>
        /// Путь к файлу для записи нечетных строк.
        /// </summary>
        string oddFile = @"odd.txt";       

        /// <summary>
        /// Читает все строки из исходного файла.
        /// </summary>
        string[] lines = File.ReadAllLines(inputFile);

        /// <summary>
        /// Записывает четные строки (индексы 1-based) в файл even.txt.
        /// </summary>
        File.WriteAllLines(evenFile, lines.Where((line, index) => index % 2 == 1)); 

        /// <summary>
        /// Записывает нечетные строки в файл odd.txt.
        /// </summary>
        File.WriteAllLines(oddFile, lines.Where((line, index) => index % 2 == 0)); 

        /// <summary>
        /// Выводит сообщение об успешном завершении разделения строк.
        /// </summary>
        Console.WriteLine("Разделение строк выполнено.");
        Console.ReadLine();
    }
}

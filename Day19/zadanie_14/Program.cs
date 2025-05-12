using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы, выполняющий обработку данных из файлов и анализ числовых значений.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет чтение данных из файлов, анализ значений и проверку свойств последовательностей.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к первому файлу, содержащему числовые значения.
        /// </summary>
        string file1 = "f1.dat";

        /// <summary>
        /// Путь ко второму файлу, содержащему числовые значения.
        /// </summary>
        string file2 = "f2.dat";

        /// <summary>
        /// Создание файлов и запись случайных чисел в заданном диапазоне.
        /// </summary>
        Random rand = new Random();
        File.WriteAllLines(file1, Enumerable.Range(0, 10).Select(_ => rand.Next(-10, 10).ToString()));
        File.WriteAllLines(file2, Enumerable.Range(0, 10).Select(_ => rand.Next(-10, 10).ToString()));

        /// <summary>
        /// Чтение данных из файлов и преобразование их в массив чисел.
        /// </summary>
        int[] f1Numbers = File.ReadAllLines(file1).Select(int.Parse).ToArray();
        int[] f2Numbers = File.ReadAllLines(file2).Select(int.Parse).ToArray();

        /// <summary>
        /// Поиск числа в f2.dat, ближайшего к минимальному значению.
        /// </summary>
        int minF2 = f2Numbers.Min();
        int closestToMin = f2Numbers.OrderBy(n => Math.Abs(n - minF2)).Skip(1).First();
        Console.WriteLine($"Число, ближайшее к минимальному ({minF2}): {closestToMin}");

        /// <summary>
        /// Метод для подсчета количества положительных, отрицательных и нулевых значений.
        /// </summary>
        /// <param name="numbers">Массив чисел для анализа.</param>
        /// <param name="fileName">Имя файла, содержащего числа.</param>
        void CountNumbers(int[] numbers, string fileName)
        {
            int positive = numbers.Count(n => n > 0);
            int negative = numbers.Count(n => n < 0);
            int zero = numbers.Count(n => n == 0);
            Console.WriteLine($"{fileName}: положительных - {positive}, отрицательных - {negative}, нулевых - {zero}");
        }

        CountNumbers(f1Numbers, "f1.dat");
        CountNumbers(f2Numbers, "f2.dat");

        /// <summary>
        /// Проверка, упорядочены ли числа в f1.dat по возрастанию.
        /// </summary>
        bool isSorted = f1Numbers.SequenceEqual(f1Numbers.OrderBy(n => n));
        Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isSorted}");

        /// <summary>
        /// Проверка, образуют ли числа в f1.dat знакопеременную последовательность.
        /// </summary>
        bool isAlternating = f1Numbers.Zip(f1Numbers.Skip(1), (a, b) => Math.Sign(a) != Math.Sign(b)).All(x => x);
        Console.WriteLine($"Числа в f1.dat образуют знакопеременную последовательность: {isAlternating}");

        Console.ReadLine();
    }
}

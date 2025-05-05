using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "f1.dat";
        string file2 = "f2.dat";

        // Создание файлов и запись случайных чисел
        Random rand = new Random();
        File.WriteAllLines(file1, Enumerable.Range(0, 10).Select(_ => rand.Next(-10, 10).ToString()));
        File.WriteAllLines(file2, Enumerable.Range(0, 10).Select(_ => rand.Next(-10, 10).ToString()));

        // Чтение данных из файлов
        int[] f1Numbers = File.ReadAllLines(file1).Select(int.Parse).ToArray();
        int[] f2Numbers = File.ReadAllLines(file2).Select(int.Parse).ToArray();

        // 1. Найти в f2.dat число, ближайшее к минимальному
        int minF2 = f2Numbers.Min();
        int closestToMin = f2Numbers.OrderBy(n => Math.Abs(n - minF2)).Skip(1).First();
        Console.WriteLine($"Число, ближайшее к минимальному ({minF2}): {closestToMin}");

        // 2. Определить количество положительных, отрицательных и нулевых значений в обоих файлах
        void CountNumbers(int[] numbers, string fileName)
        {
            int positive = numbers.Count(n => n > 0);
            int negative = numbers.Count(n => n < 0);
            int zero = numbers.Count(n => n == 0);
            Console.WriteLine($"{fileName}: положительных - {positive}, отрицательных - {negative}, нулевых - {zero}");
        }

        CountNumbers(f1Numbers, "f1.dat");
        CountNumbers(f2Numbers, "f2.dat");

        // 3. Проверить, упорядочены ли числа f1.dat по возрастанию
        bool isSorted = f1Numbers.SequenceEqual(f1Numbers.OrderBy(n => n));
        Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isSorted}");

        // 4. Проверить, образуют ли числа в f1.dat знакопеременную последовательность
        bool isAlternating = f1Numbers.Zip(f1Numbers.Skip(1), (a, b) => Math.Sign(a) != Math.Sign(b)).All(x => x);
        Console.WriteLine($"Числа в f1.dat образуют знакопеременную последовательность: {isAlternating}");

        Console.ReadLine();
    }
}

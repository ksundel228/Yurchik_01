using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ввод размера массива
        Console.Write("Введите размер массива: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int size) || size <= 0)
        {
            Console.WriteLine("Ошибка: размер массива должен быть натуральным числом.");
            return;
        }

        // Создание и заполнение массива случайными числами
        int[] array = new int[size];
        Random random = new Random();

        Console.WriteLine("Сформированный массив:");
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(-100, 101); // Числа в диапазоне [-100, 100]
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Вычисление среднего значения всех элементов массива
        double average = array.Average();
        Console.WriteLine($"Среднее значение всех элементов массива: {average}");

        // Поиск элемента, наиболее близкого к среднему значению
        int closestValue = array.OrderBy(x => Math.Abs(x - average)).First();
        int closestIndex = Array.IndexOf(array, closestValue);
        Console.WriteLine($"Элемент, наиболее близкий к среднему значению: {closestValue}, его индекс: {closestIndex}");

        // Вычисление суммы элементов массива
        int sum = array.Sum();
        Console.WriteLine($"Сумма элементов массива: {sum}");

        // Проверка, является ли сумма четырехзначным числом
        if (sum >= 1000 && sum <= 9999)
        {
            Console.WriteLine("Сумма элементов массива является четырехзначным числом.");
        }
        else
        {
            Console.WriteLine("Сумма элементов массива не является четырехзначным числом.");
        }
    }
}

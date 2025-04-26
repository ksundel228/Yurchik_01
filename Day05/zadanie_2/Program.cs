using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ввод размера массива
        Console.Write("Введите количество элементов массива (натуральное число n): ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n <= 0)
        {
            Console.WriteLine("Ошибка: Введите корректное натуральное число.");
            return;
        }

        // Создание массива с случайными натуральными числами
        int[] array = new int[n];
        Random random = new Random();

        Console.WriteLine("Сформированный массив:");
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(1, 100); 
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Сортировка массива
        Array.Sort(array);
        Console.WriteLine("Отсортированный массив:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Определение количества нечётных элементов
        int oddCount = array.Count(x => x % 2 != 0);
        Console.WriteLine($"Количество нечётных элементов: {oddCount}");

        // Бинарный поиск числа k
        Console.Write("Введите число k для бинарного поиска: ");
        string? kInput = Console.ReadLine();

        if (!int.TryParse(kInput, out int k))
        {
            Console.WriteLine("Ошибка: Введите корректное число.");
            return;
        }

        int index = Array.BinarySearch(array, k);

        if (index >= 0)
        {
            Console.WriteLine($"Число {k} найдено на позиции {index}.");
        }
        else
        {
            Console.WriteLine($"Число {k} не найдено в массиве.");
        }
    }
}

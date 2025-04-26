using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число N (1 <= N <= 20):");
        int N = int.Parse(Console.ReadLine());

        if (N >= 1 && N <= 20)
        {
            double sum = 0.0;

            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"Сумма: {sum:F4}"); // Вывод с точностью до 4 знаков
        }
        else
        {
            Console.WriteLine("Ошибка: N должно быть в диапазоне от 1 до 20.");
        }
    }
}

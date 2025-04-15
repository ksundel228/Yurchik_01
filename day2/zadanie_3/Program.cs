using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вещественное число A (-5 <= A <= 5): ");
        double A = double.Parse(Console.ReadLine());
        
        Console.Write("Введите целое число N (1 <= N <= 10): ");
        int N = int.Parse(Console.ReadLine());

        // Проверяем входные данные на соответствие ограничениям
        if (A < -5 || A > 5 || N < 1 || N > 10)
        {
            Console.WriteLine("Введены неверные значения. Проверьте ограничения.");
            return;
        }

        Console.WriteLine($"Целые степени числа {A} от 1 до {N}:");
        
        // Вывод всех степеней числа A от 1 до N
        double result = 1; // Начальное значение (A^0 = 1)
        for (int i = 1; i <= N; i++)
        {
            result *= A; // Умножение предыдущего результата на A
            Console.WriteLine($"{result:F4}");
        }
    }
}

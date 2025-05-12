using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int A = -8;
        int B = 5;

        Console.WriteLine("Параллельное вычисление cos(x^2) на отрезке [-8, 5]:");

        // Используем Parallel.For для параллельного выполнения расчетов
        Parallel.For(A, B + 1, x =>
        {
            double result = Math.Cos(Math.Pow(x, 2));
            Console.WriteLine($"x = {x}, cos(x^2) = {result}");
        });

        Console.WriteLine("Вычисления завершены!");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Заданные параметры
        double A = Math.PI / 3;
        double B = 3 * Math.PI / 2;
        int M = 15;

        // Шаг табулирования
        double H = (B - A) / M;

        Console.WriteLine("Табулирование функции F(x) = cos(x^2):");
        Console.WriteLine("x\t\tF(x)");

        // Вычисление значений функции в точках
        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double F = Math.Cos(x * x);
            Console.WriteLine($"{x:F4}\t{F:F4}");
        }
    }
}

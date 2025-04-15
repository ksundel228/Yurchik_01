using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x = double.Parse(Console.ReadLine());
        double y;

        if (x > 2)
        {
            y = Math.Pow(x, 3) * Math.Sqrt(x - 2);
        }
        else if (x == 2)
        {
            y = x * Math.Sin(2 * x);
        }
        else // x < 2
        {
            y = Math.Exp(-2 * x) * Math.Cos(2 * x);
        }

        Console.WriteLine($"Значение y: {y}");
    }
}

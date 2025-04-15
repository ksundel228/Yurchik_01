using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 5.2;

        // (x^2 + 5)^2
        double innerSquare = Math.Pow(Math.Pow(x, 2) + 5, 2);

        // sin^3(innerSquare)
        double sinCubed = Math.Pow(Math.Sin(innerSquare), 3);

        // sqrt(x / 4)
        double sqrtPart = Math.Sqrt(x / 4);

        double y = sinCubed - sqrtPart;

        Console.WriteLine($"При x = {x}, значение функции y = {y:F4}");
    }
}

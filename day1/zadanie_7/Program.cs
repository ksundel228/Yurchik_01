using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение угла α в градусах: ");
        double alphaDegrees = double.Parse(Console.ReadLine());

        double alphaRadians = alphaDegrees * Math.PI / 180; // Перевод в радианы

        double z1 = 1 - (Math.Pow(Math.Sin(2 * alphaRadians), 2) / 4) + Math.Cos(2 * alphaRadians);
        double z2 = Math.Pow(Math.Cos(alphaRadians), 2) + Math.Pow(Math.Cos(alphaRadians), 4);

        Console.WriteLine($"Результат по формуле z1: {z1}");
        Console.WriteLine($"Результат по формуле z2: {z2}");
    }
}

// Тестовые примеры: α = 0°: α = 45° Результаты по первой и второй формуле совпадают.

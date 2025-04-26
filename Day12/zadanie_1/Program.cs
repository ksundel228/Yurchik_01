using System;

public class Program
{
    // Объявление типа делегата
    public delegate double CalcFigure(double radius);

    // Статический метод для вычисления длины окружности
    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    // Статический метод для вычисления площади круга
    public static double Get_Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    // Статический метод для вычисления объема шара
    public static double Get_Volume(double radius)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
    }

    public static void Main()
    {
        // Создание экземпляра делегата
        CalcFigure CF;

        double radius = 5.0; // Радиус

        // Вызов методов через делегат
        CF = Get_Length;
        Console.WriteLine($"Длина окружности радиуса {radius}: {CF(radius):F2}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга радиуса {radius}: {CF(radius):F2}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара радиуса {radius}: {CF(radius):F2}");
    }
}

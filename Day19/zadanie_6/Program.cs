using System;

/// <summary>
/// Главный класс программы, выполняющий вычисления геометрических параметров окружности, круга и шара.
/// </summary>
public class Program
{
    /// <summary>
    /// Делегат, представляющий метод вычисления геометрической фигуры по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Результат вычисления.</returns>
    public delegate double CalcFigure(double radius);

    /// <summary>
    /// Вычисляет длину окружности по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Вычисляет площадь круга по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    public static double Get_Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    /// Вычисляет объем шара по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус шара.</param>
    /// <returns>Объем шара.</returns>
    public static double Get_Volume(double radius)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
    }

    /// <summary>
    /// Точка входа в программу. Выполняет вычисления с использованием делегата и выводит результаты.
    /// </summary>
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

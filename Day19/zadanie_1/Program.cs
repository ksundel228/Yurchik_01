using System;

/// <summary>
/// Главный класс программы, выполняющий расчет значений функции f(x).
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет значение функции f(x) по заданным условиям.
    /// </summary>
    /// <param name="x">Значение аргумента x.</param>
    /// <param name="a">Начальное значение диапазона.</param>
    /// <param name="b">Конечное значение диапазона.</param>
    /// <returns>Рассчитанное значение функции.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если x выходит за допустимые границы.</exception>
    static double Function(double x, double a, double b)
    {
        if (2 * x <= -5)
        {
            return (x * x + x) / (a * x);
        }
        else if (-5 <= 2 * x && 2 * x <= 0)
        {
            return b - a;
        }
        else if (0 < 2 * x)
        {
            return 3 * x * x + (b * x) / Math.Pow(x, 4);
        }
        throw new ArgumentOutOfRangeException("x", "Unexpected value for x");
    }

    /// <summary>
    /// Точка входа в программу. Запрашивает у пользователя ввод параметров,
    /// строит таблицу значений функции и выводит их в консоль.
    /// </summary>
    static void Main()
    {
        // Ввод параметров a, b и h с клавиатуры
        Console.Write("Введите начальное значение a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите конечное значение b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите шаг h: ");
        double h = double.Parse(Console.ReadLine());

        // Построение таблицы значений функции
        Console.WriteLine("\nТаблица значений функции:");
        Console.WriteLine("{0,10} {1,10}", "x", "f(x)");

        for (double x = a; x <= b; x += h)
        {
            try
            {
                double y = Function(x, a, b);
                Console.WriteLine("{0,10:F2} {1,10:F2}", x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0,10:F2} {1,10}", x, "Ошибка");
            }
        }
    }
}

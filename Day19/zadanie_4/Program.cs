using System;

/// <summary>
/// Главный класс программы, выполняющий проверку положительности чисел.
/// </summary>
class Program
{
    /// <summary>
    /// Проверяет, являются ли два целых числа положительными.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>True, если оба числа положительные; иначе false.</returns>
    static bool ArePositive(int a, int b)
    {
        return a > 0 && b > 0;
    }

    /// <summary>
    /// Проверяет, являются ли три целых числа положительными.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>True, если все три числа положительные; иначе false.</returns>
    static bool ArePositive(int a, int b, int c)
    {
        return a > 0 && b > 0 && c > 0;
    }

    /// <summary>
    /// Проверяет, являются ли два логических значения истинными.
    /// </summary>
    /// <param name="val1">Первое логическое значение.</param>
    /// <param name="val2">Второе логическое значение.</param>
    /// <returns>True, если оба значения истинны; иначе false.</returns>
    static bool ArePositive(bool val1, bool val2)
    {
        return val1 && val2;
    }

    /// <summary>
    /// Точка входа в программу. Запрашивает у пользователя ввод чисел и выполняет проверку положительности.
    /// </summary>
    static void Main()
    {
        // Считывание параметров с клавиатуры
        Console.Write("Введите a1: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите b1: ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("Введите a2: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        int b2 = int.Parse(Console.ReadLine());

        Console.Write("Введите c2: ");
        int c2 = int.Parse(Console.ReadLine());

        // Промежуточные результаты
        bool result1 = ArePositive(a1, b1);
        bool result2 = ArePositive(a2, b2, c2);

        // Финальный результат
        bool finalResult = ArePositive(result1, result2);

        Console.WriteLine($"Результат: {finalResult}");
    }
}

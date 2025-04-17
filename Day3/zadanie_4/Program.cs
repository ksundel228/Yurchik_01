using System;

class Program
{
    // Метод ArePositive для двух чисел
    static bool ArePositive(int a, int b)
    {
        return a > 0 && b > 0;
    }

    // Перегрузка метода ArePositive для трех чисел
    static bool ArePositive(int a, int b, int c)
    {
        return a > 0 && b > 0 && c > 0;
    }

    // Перегрузка метода ArePositive для двух логических значений
    static bool ArePositive(bool val1, bool val2)
    {
        return val1 && val2;
    }

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

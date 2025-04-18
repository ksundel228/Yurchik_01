using System;

class Program
{
    // Метод для вычисления первого выражения
    static double CalculateFirstExpression(double x)
    {
        if (x == 4)
        {
            throw new DivideByZeroException("Деление на ноль в выражении (4 - x)");
        }
        return 4 - (x - 7) / (4 - x);
    }

    // Метод для вычисления второго выражения
    static double CalculateSecondExpression(double x)
    {
        if (x * x * x == 1)
        {
            throw new DivideByZeroException("Деление на ноль в выражении (x^3 - 1)");
        }
        return Math.Sin(x) / (Math.Pow(x, 3) - 1);
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new FormatException("Пустой ввод. Пожалуйста, введите число.");
            }

            double x = double.Parse(input);

            // Вычисление первого выражения
            double result1 = CalculateFirstExpression(x);
            Console.WriteLine($"Результат первого выражения: {result1:F2}");

            // Вычисление второго выражения
            double result2 = CalculateSecondExpression(x);
            Console.WriteLine($"Результат второго выражения: {result2:F2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
        }
    }
}

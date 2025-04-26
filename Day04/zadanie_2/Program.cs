using System;

class Program
{
    // Метод для вычисления значения функции f(x)
    static double Function(double x)
    {
        if (x > 10 || x < -10)
        {
            throw new ArgumentOutOfRangeException(nameof(x), "Значение x выходит за допустимый диапазон [-10, 10].");
        }

        if (-1 < x && x < 1)
        {
            return x + 14;
        }
        else if (x >= 1)
        {
            if (x == 4)
            {
                throw new DivideByZeroException("Деление на ноль в выражении (x - 4).");
            }
            return (x - 1) / (x - 4);
        }
        else
        {
            throw new ArgumentException("Недопустимое значение x для функции.");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите значение x ([-10, 10]): ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new FormatException("Пустой ввод. Пожалуйста, введите число.");
            }

            double x = double.Parse(input);

            // Вычисление функции
            double result = Function(x);
            Console.WriteLine($"Значение функции f(x): {result:F2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
        }
    }
}

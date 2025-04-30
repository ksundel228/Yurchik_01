using System;

delegate double FunctionDelegate(double x);

class Program
{
    // Метод 1
    static double Function1(double x)
    {
        if (x < 0)
            throw new ArgumentException("Значение x не может быть отрицательным.");
        return Math.Sqrt(x);
    }

    // Метод 2
    static double Function2(double x)
    {
        return Math.Pow(x, 2);
    }

    // Метод 3
    static double Function3(double x)
    {
        if (x == 0)
            throw new DivideByZeroException("Деление на ноль запрещено.");
        return 1 / x;
    }

    // Метод, принимающий делегат в качестве параметра
    static void ExecuteFunction(FunctionDelegate function, double value)
    {
        try
        {
            Console.WriteLine($"Результат выполнения: {function(value)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Операция завершена.");
        }
    }

    static void Main()
    {
        double input;

        // Запрос значения
        Console.Write("Введите число: ");
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Ошибка! Введите корректное число.");
            Console.Write("Введите число: ");
        }

        // Вызов метода с различными функциями
        ExecuteFunction(Function1, input);
        ExecuteFunction(Function2, input);
        ExecuteFunction(Function3, input);
    }
}

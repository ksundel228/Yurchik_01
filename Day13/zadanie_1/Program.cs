using System;

// Определение делегата
delegate double FunctionDelegate(double x);

class Program
{
    // Метод 1: вычисляет квадратный корень
    static double Function1(double x)
    {
        if (x < 0)
            throw new ArgumentException("Значение x не может быть отрицательным.");
        return Math.Sqrt(x);
    }

    // Метод 2: вычисляет квадрат числа
    static double Function2(double x)
    {
        return Math.Pow(x, 2);
    }

    // Метод 3: вычисляет обратное значение
    static double Function3(double x)
    {
        if (x == 0)
            throw new DivideByZeroException("Деление на ноль запрещено.");
        return 1 / x;
    }

    static void Main()
    {
        // Создание делегата и добавление методов
        FunctionDelegate del = Function1;
        del += Function2;
        del += Function3;

        double input;

        // Запрос значения у пользователя
        Console.Write("Введите число: ");
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Ошибка! Введите корректное число.");
            Console.Write("Введите число: ");
        }

        // Вызов всех методов через делегат
        foreach (FunctionDelegate func in del.GetInvocationList())
        {
            try
            {
                Console.WriteLine($"Результат: {func(input)}");
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
    }
}

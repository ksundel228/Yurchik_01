using System;

/// <summary>
/// Главный класс программы, выполняющий арифметические операции с использованием лямбда-выражений.
/// </summary>
public class Program
{
    /// <summary>
    /// Точка входа в программу. Запрашивает у пользователя выбор арифметической операции и выполняет её.
    /// </summary>
    public static void Main()
    {
        // Объявление лямбда-операторов для арифметических действий

        /// <summary>
        /// Лямбда-выражение для выполнения сложения двух чисел.
        /// </summary>
        Func<double, double, double> Add = (x, y) => x + y;

        /// <summary>
        /// Лямбда-выражение для выполнения вычитания двух чисел.
        /// </summary>
        Func<double, double, double> Sub = (x, y) => x - y;

        /// <summary>
        /// Лямбда-выражение для выполнения умножения двух чисел.
        /// </summary>
        Func<double, double, double> Mul = (x, y) => x * y;

        /// <summary>
        /// Лямбда-выражение для выполнения деления двух чисел. Проверяет деление на ноль.
        /// </summary>
        Func<double, double, double> Div = (x, y) =>
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль!");
                return double.NaN; // Возврат специального значения
            }
            return x / y;
        };

        // Меню для выбора действия
        Console.WriteLine("Выберите арифметическое действие:");
        Console.WriteLine("1. Сложение (Add)");
        Console.WriteLine("2. Вычитание (Sub)");
        Console.WriteLine("3. Умножение (Mul)");
        Console.WriteLine("4. Деление (Div)");

        int choice = int.Parse(Console.ReadLine());

        // Ввод значений
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        /// <summary>
        /// Переменная для хранения результата вычисления.
        /// </summary>
        double result = 0;

        // Выполнение выбранного действия
        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                Console.WriteLine($"Результат сложения: {result:F2}");
                break;
            case 2:
                result = Sub(num1, num2);
                Console.WriteLine($"Результат вычитания: {result:F2}");
                break;
            case 3:
                result = Mul(num1, num2);
                Console.WriteLine($"Результат умножения: {result:F2}");
                break;
            case 4:
                result = Div(num1, num2);
                if (!double.IsNaN(result))
                    Console.WriteLine($"Результат деления: {result:F2}");
                break;
            default:
                Console.WriteLine("Неверный выбор действия!");
                break;
        }
    }
}

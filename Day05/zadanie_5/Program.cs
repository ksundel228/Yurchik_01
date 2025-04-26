using System;

class Program
{
    // Рекурсивный метод для вычисления факториала
    static int Factorial(int n)
    {
        if (n <= 1) return 1; // Условие выхода
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        // Ввод исходных данных
        Console.Write("Введите значение n: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 4)
        {
            Console.WriteLine("Ошибка: n должно быть целым числом больше или равно 4.");
            return;
        }

        // Вычисление f(n)
        int factorialNMinus3 = Factorial(n - 3);
        int factorialNMinus4 = Factorial(n - 4);
        double result = (double)factorialNMinus3 / factorialNMinus4;

        // Вывод результата
        Console.WriteLine($"f({n}) = {result}");
    }
}

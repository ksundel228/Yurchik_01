using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 7, 93, 90 }; // Заданный массив значений
        int sumThreshold = 1000; // Условие выхода по сумме
        int productThreshold = 2000000; // Условие выхода по произведению

        Console.WriteLine("Начало параллельных вычислений...");

        // Используем Parallel.ForEach с возможностью прерывания
        Parallel.ForEach(numbers, (n, state) =>
        {
            int sum = 0;
            int product = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                product *= i;

                if (sum > sumThreshold || product > productThreshold)
                {
                    Console.WriteLine($"Прерывание вычислений для N = {n}: сумма = {sum}, произведение = {product}");
                    state.Break(); // Прерываем выполнение Parallel.ForEach
                    return;
                }
            }

            Console.WriteLine($"N = {n}, сумма = {sum}, произведение = {product}");
        });

        Console.WriteLine("Вычисления завершены!");
    }
}

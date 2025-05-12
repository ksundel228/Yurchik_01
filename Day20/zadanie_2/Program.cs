using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    // Функция 1: Вычисление z1 = 1 - (1/4) * sin^2(2α) + cos(2α)
    static double CalculateZ1(double alpha)
    {
        Thread.Sleep(2000); // Имитация задержки выполнения
        return 1 - (1.0 / 4) * Math.Pow(Math.Sin(2 * alpha), 2) + Math.Cos(2 * alpha);
    }

    // Функция 2: Вычисление z2 = cos^2(α) + cos^4(α)
    static double CalculateZ2(double alpha)
    {
        Thread.Sleep(3000); // Имитация задержки выполнения
        return Math.Pow(Math.Cos(alpha), 2) + Math.Pow(Math.Cos(alpha), 4);
    }

    static void Main()
    {
        double alpha = Math.PI / 4; // Пример значения α

        // Создаем массив из двух задач
        Task<double>[] tasks = new Task<double>[2]
        {
            Task.Run(() => CalculateZ1(alpha)),
            Task.Run(() => CalculateZ2(alpha))
        };

        // Условие 1: Дождаться выполнения всех задач
        Task.WaitAll(tasks);
        Console.WriteLine($"Все задачи завершены. Результаты: Z1 = {tasks[0].Result}, Z2 = {tasks[1].Result}");

        // Условие 2: Дождаться выполнения хотя бы одной задачи
        Task.WaitAny(tasks);
        Console.WriteLine("Хотя бы одна задача завершилась.");
    }
}

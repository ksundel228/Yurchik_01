using System;

/// <summary>
/// Главный класс программы, выполняющий генерацию случайных чисел и вычисление среднего арифметического.
/// </summary>
public class Program
{
    /// <summary>
    /// Делегат, представляющий метод генерации случайного числа.
    /// </summary>
    /// <returns>Случайное число в заданном диапазоне.</returns>
    public delegate int RandomDelegate();

    /// <summary>
    /// Точка входа в программу. Генерирует случайные числа, вычисляет их среднее арифметическое и выводит результат.
    /// </summary>
    public static void Main()
    {
        // Создание экземпляра генератора случайных чисел
        Random random = new Random();

        /// <summary>
        /// Метод-делегат для генерации случайного числа в диапазоне от 1 до 100.
        /// </summary>
        RandomDelegate method1 = () => random.Next(1, 101);

        /// <summary>
        /// Метод-делегат для генерации случайного числа в диапазоне от 1 до 100.
        /// </summary>
        RandomDelegate method2 = () => random.Next(1, 101);

        /// <summary>
        /// Метод-делегат для генерации случайного числа в диапазоне от 1 до 100.
        /// </summary>
        RandomDelegate method3 = () => random.Next(1, 101);

        /// <summary>
        /// Метод-делегат для генерации случайного числа в диапазоне от 1 до 100.
        /// </summary>
        RandomDelegate method4 = () => random.Next(1, 101);

        // Массив делегатов
        RandomDelegate[] delegatesArray = { method1, method2, method3, method4 };

        /// <summary>
        /// Анонимный метод для вычисления среднего арифметического значений, возвращаемых делегатами.
        /// </summary>
        /// <param name="delegates">Массив делегатов, каждый из которых возвращает случайное число.</param>
        /// <returns>Среднее арифметическое чисел.</returns>
        Func<RandomDelegate[], double> calculateAverage = (delegates) =>
        {
            double sum = 0;
            Console.WriteLine("Сгенерированные значения:");
            foreach (var del in delegates)
            {
                int value = del(); // Получение значения от делегата
                Console.WriteLine(value); // Вывод значения
                sum += value;
            }
            return sum / delegates.Length;
        };

        // Вычисление и вывод результата
        double average = calculateAverage(delegatesArray);
        Console.WriteLine($"\nСреднее арифметическое значений: {average:F2}");
    }
}

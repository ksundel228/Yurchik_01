using System;

public class Program
{
    // Объявление делегата
    public delegate int RandomDelegate();

    public static void Main()
    {
        // Создание методов, сообщенных с делегатами, возвращающих случайное значение
        Random random = new Random();

        RandomDelegate method1 = () => random.Next(1, 101);
        RandomDelegate method2 = () => random.Next(1, 101);
        RandomDelegate method3 = () => random.Next(1, 101);
        RandomDelegate method4 = () => random.Next(1, 101);

        // Массив делегатов
        RandomDelegate[] delegatesArray = { method1, method2, method3, method4 };

        // Анонимный метод для вычисления среднего арифметического
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
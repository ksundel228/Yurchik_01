using System;

class Program
{
    static void Main()
    {
        // Ввод размера матрицы
        Console.Write("Введите размер матрицы N (N < 10): ");
        string? inputN = Console.ReadLine();
        if (!int.TryParse(inputN, out int N) || N <= 0 || N >= 10)
        {
            Console.WriteLine("Ошибка: Размер матрицы должен быть натуральным числом меньше 10.");
            return;
        }

        // Ввод диапазона [a, b]
        Console.Write("Введите минимальное значение диапазона a: ");
        string? inputA = Console.ReadLine();
        Console.Write("Введите максимальное значение диапазона b: ");
        string? inputB = Console.ReadLine();

        if (!int.TryParse(inputA, out int a) || !int.TryParse(inputB, out int b) || a > b)
        {
            Console.WriteLine("Ошибка: Убедитесь, что a <= b.");
            return;
        }

        // Создание и заполнение матрицы
        int[,] matrix = new int[N, N];
        Random random = new Random();

        Console.WriteLine("Сформированная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(a, b + 1); // Случайное число в диапазоне [a, b]
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Вычисление суммы квадратов положительных чисел
        int sumOfSquares = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] > 0)
                {
                    sumOfSquares += matrix[i, j] * matrix[i, j];
                }
            }
        }
        Console.WriteLine($"Сумма квадратов положительных чисел: {sumOfSquares}");

        // Вычисление суммы элементов каждой строки
        Console.WriteLine("Суммы элементов каждой строки:");
        for (int i = 0; i < N; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < N; j++)
            {
                rowSum += matrix[i, j];
            }
            Console.WriteLine($"Сумма элементов строки {i + 1}: {rowSum}");
        }
    }
}

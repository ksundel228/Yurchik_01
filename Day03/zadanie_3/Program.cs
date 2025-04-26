using System;

class Matrix
{
    private int[,] data;
    private int rows, cols;

    // Конструктор для создания матрицы с заданным размером и заполнением случайными числами
    public Matrix(int rows, int cols, int minValue = 0, int maxValue = 10)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
        Random random = new Random();

        // Заполнение матрицы случайными числами
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                data[i, j] = random.Next(minValue, maxValue);
            }
        }
    }

    // Перегрузка операции умножения
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.cols != b.rows)
        {
            throw new InvalidOperationException("Матрицы не согласованы для умножения!");
        }

        Matrix result = new Matrix(a.rows, b.cols);
        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < b.cols; j++)
            {
                result.data[i, j] = 0;
                for (int k = 0; k < a.cols; k++)
                {
                    result.data[i, j] += a.data[i, k] * b.data[k, j];
                }
            }
        }
        return result;
    }

    // Метод для вывода матрицы на экран
    public void Display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Создание случайных матриц
        Matrix A = new Matrix(2, 3); // Матрица 2x3
        Matrix B = new Matrix(3, 2); // Матрица 3x2

        Console.WriteLine("Матрица A:");
        A.Display();
        Console.WriteLine("\nМатрица B:");
        B.Display();

        try
        {
            Matrix C = A * B;
            Console.WriteLine("\nРезультат умножения матриц:");
            C.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int n = 7; // Размер массива
        int[,] spiralArray = new int[n, n];

        int value = 1; // Значение для заполнения
        int startRow = 0, startCol = 0;
        int endRow = n - 1, endCol = n - 1;

        while (value <= n * n)
        {
            // Заполняем верхнюю строку слева направо
            for (int i = startCol; i <= endCol; i++)
            {
                spiralArray[startRow, i] = value++;
            }
            startRow++;

            // Заполняем правый столбец сверху вниз
            for (int i = startRow; i <= endRow; i++)
            {
                spiralArray[i, endCol] = value++;
            }
            endCol--;

            // Заполняем нижнюю строку справа налево
            for (int i = endCol; i >= startCol; i--)
            {
                spiralArray[endRow, i] = value++;
            }
            endRow--;

            // Заполняем левый столбец снизу вверх
            for (int i = endRow; i >= startRow; i--)
            {
                spiralArray[i, startCol] = value++;
            }
            startCol++;
        }

        // Вывод массива на экран
        Console.WriteLine("Двумерный массив, заполненный по спирали:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j],2} ");
            }
            Console.WriteLine();
        }
    }
}

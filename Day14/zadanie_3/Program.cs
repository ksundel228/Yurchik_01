using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());

        Thread thread1 = new Thread(() => SumSeries(A, N));
        Thread thread2 = new Thread(() => SumSeries(A, N));
        Thread thread3 = new Thread(() => MultiplySeries(A, N));

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершены.");
    }

    static void SumSeries(int A, int N)
    {
        int sum = 0;
        for (int i = 0; i <= N; i++)
        {
            sum += (int)Math.Pow(A, i);
        }
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма ряда = {sum}");
    }

    static void MultiplySeries(int A, int N)
    {
        int product = 1;
        for (int i = 0; i <= N; i++)
        {
            product *= (int)Math.Pow(A, i);
        }
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Произведение ряда = {product}");
    }
}

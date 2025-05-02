using System;
using System.Threading;

class Program
{
    static AutoResetEvent firstDone = new AutoResetEvent(false);
    static AutoResetEvent secondDone = new AutoResetEvent(false);

    static void Main()
    {
        Thread firstThread = new Thread(PrintNumbers);
        Thread secondThread = new Thread(PrintNumbers);
        Thread thirdThread = new Thread(PrintNumbers);

        firstThread.Priority = ThreadPriority.Highest;
        secondThread.Priority = ThreadPriority.Normal;
        thirdThread.Priority = ThreadPriority.Lowest;

        firstThread.Start(0);
        secondThread.Start(10);
        thirdThread.Start(20);

        firstThread.Join();
        secondThread.Join();
        thirdThread.Join();

        Console.WriteLine("Все потоки завершены.");
    }

    static void PrintNumbers(object startObj)
    {
        int start = (int)startObj;
        for (int i = start; i < start + 10; i++)
        {
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: {i}");
            Thread.Sleep(100);
        }

        if (start == 0)
            firstDone.Set();
        else if (start == 10)
            secondDone.Set();
    }
}

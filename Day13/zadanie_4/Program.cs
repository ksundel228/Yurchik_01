using System;

// Определение класса с событием
class EventSource
{
    public delegate void EventHandler(string message);
    public event EventHandler OnEvent;

    public void TriggerEvent(string message)
    {
        Console.WriteLine("Событие активировано.");
        OnEvent?.Invoke(message);
    }
}

// Первый класс-наблюдатель
class Observer1
{
    public void React1(string message)
    {
        Console.WriteLine($"Observer1 получил событие: {message}");
    }

    public void React2(string message)
    {
        Console.WriteLine($"Observer1 (второй обработчик) получил событие: {message}");
    }
}

// Второй класс-наблюдатель
class Observer2
{
    public void React(string message)
    {
        Console.WriteLine($"Observer2 получил событие: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Создание источника события
        EventSource source = new EventSource();
        
        // Создание наблюдателей
        Observer1 obs1 = new Observer1();
        Observer2 obs2 = new Observer2();

        // Добавление обработчиков
        source.OnEvent += obs1.React1;
        source.OnEvent += obs1.React2;
        source.OnEvent += obs2.React;

        // Активация события
        source.TriggerEvent("Первый вызов события");

        // Удаление одного обработчика
        source.OnEvent -= obs1.React1;

        Console.WriteLine("\nПосле удаления одного обработчика:\n");

        // Повторная активация события
        source.TriggerEvent("Второй вызов события");
    }
}

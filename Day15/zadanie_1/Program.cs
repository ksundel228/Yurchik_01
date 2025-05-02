using System;

class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[10]; // Начальный размер массива
        count = 0;
    }

    // Метод для добавления элемента
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2); // Увеличиваем размер массива
        }
        items[count] = item;
        count++;
    }

    // Индексатор для получения значения по индексу
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
            return items[index];
        }
    }

    // Свойство для получения количества элементов
    public int Count
    {
        get { return count; }
    }
}

class Program
{
    static void Main()
    {
        MyList<int> list = new MyList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Console.WriteLine($"Элемент с индексом 1: {list[1]}"); // 20
        Console.WriteLine($"Общее количество элементов: {list.Count}"); // 3
    }
}

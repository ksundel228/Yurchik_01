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

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count] = item;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за границы списка.");
            return items[index];
        }
    }

    public int Count => count;
}

static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
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

        int[] array = list.GetArray();

        Console.WriteLine("Элементы массива:");
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
}

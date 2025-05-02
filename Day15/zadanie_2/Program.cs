using System;

class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public MyDictionary()
    {
        keys = new TKey[10]; // Начальный размер массива
        values = new TValue[10];
        count = 0;
    }

    // Метод для добавления пары ключ-значение
    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
            Array.Resize(ref values, values.Length * 2);
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    // Индексатор для получения значения по индексу
    public TValue this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за границы словаря.");
            return values[index];
        }
    }

    // Свойство для получения количества пар элементов
    public int Count
    {
        get { return count; }
    }
}

class Program
{
    static void Main()
    {
        MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

        dictionary.Add(1, "Apple");
        dictionary.Add(2, "Banana");
        dictionary.Add(3, "Cherry");

        Console.WriteLine($"Значение по индексу 1: {dictionary[1]}"); 
        Console.WriteLine($"Общее количество пар элементов: {dictionary.Count}");
    }
}

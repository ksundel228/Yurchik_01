using System;

class MyInfo
{
    private string _name;

    // Определение делегата и события
    public delegate void NameChangedEventHandler(string oldName, string newName);
    public event NameChangedEventHandler NameChanged;

    // Свойство с вызовом события при изменении
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                string oldName = _name;
                _name = value;
                // Вызов события
                NameChanged?.Invoke(oldName, _name);
            }
        }
    }

    // Конструктор, устанавливающий начальное имя
    public MyInfo(string initialName)
    {
        _name = initialName;
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта с начальным именем Ksenia
        MyInfo myInfo = new MyInfo("Ksenia");

        // Подписка на событие
        myInfo.NameChanged += (oldName, newName) =>
        {
            Console.WriteLine($"Имя изменилось: {oldName} -> {newName}");
        };

        // Запрос нового имени у пользователя
        Console.Write("Введите новое имя: ");
        string newName = Console.ReadLine();
        
        // Изменение имени, вызывающее событие
        myInfo.Name = newName;
    }
}

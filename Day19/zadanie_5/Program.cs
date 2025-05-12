using System;
using System.Linq;

/// <summary>
/// Класс, представляющий продукт с названием, магазином и ценой.
/// </summary>
class Product
{
    /// <summary>
    /// Название продукта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Магазин, в котором продается продукт.
    /// </summary>
    public string Store { get; set; }

    /// <summary>
    /// Цена продукта.
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Конструктор для создания продукта.
    /// </summary>
    /// <param name="name">Название продукта.</param>
    /// <param name="store">Название магазина.</param>
    /// <param name="price">Цена продукта.</param>
    public Product(string name, string store, double price)
    {
        Name = name;
        Store = store;
        Price = price;
    }

    /// <summary>
    /// Возвращает строковое представление объекта Product.
    /// </summary>
    /// <returns>Строка с информацией о продукте.</returns>
    public override string ToString()
    {
        return $"Product: {Name}, Store: {Store}, Price: ${Price:F2}";
    }
}

/// <summary>
/// Класс, представляющий склад с продуктами.
/// </summary>
class Warehouse
{
    private Product[] products;

    /// <summary>
    /// Конструктор для создания склада с начальным набором продуктов.
    /// </summary>
    /// <param name="initialProducts">Массив начальных продуктов.</param>
    public Warehouse(Product[] initialProducts)
    {
        products = initialProducts;
    }

    /// <summary>
    /// Индексатор для получения или изменения продукта по индексу.
    /// </summary>
    /// <param name="index">Индекс продукта.</param>
    /// <returns>Продукт по заданному индексу.</returns>
    /// <exception cref="IndexOutOfRangeException">Выбрасывается, если индекс выходит за допустимые границы.</exception>
    public Product this[int index]
    {
        get
        {
            if (index >= 0 && index < products.Length)
            {
                return products[index];
            }
            throw new IndexOutOfRangeException("Invalid index!");
        }
        set
        {
            if (index >= 0 && index < products.Length)
            {
                products[index] = value;
            }
        }
    }

    /// <summary>
    /// Поиск продукта по названию.
    /// </summary>
    /// <param name="name">Название продукта.</param>
    public void FindByName(string name)
    {
        var foundProducts = products.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToArray();
        if (foundProducts.Length > 0)
        {
            Console.WriteLine("Найденные продукты:");
            foreach (var product in foundProducts)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine($"Продукт с названием \"{name}\" не найден.");
        }
    }

    /// <summary>
    /// Сортировка продуктов по магазину.
    /// </summary>
    public void SortByStore()
    {
        products = products.OrderBy(p => p.Store).ToArray();
        Console.WriteLine("Продукты отсортированы по магазину:");
        DisplayAll();
    }

    /// <summary>
    /// Сортировка продуктов по названию.
    /// </summary>
    public void SortByName()
    {
        products = products.OrderBy(p => p.Name).ToArray();
        Console.WriteLine("Продукты отсортированы по названию:");
        DisplayAll();
    }

    /// <summary>
    /// Сортировка продуктов по цене.
    /// </summary>
    public void SortByPrice()
    {
        products = products.OrderBy(p => p.Price).ToArray();
        Console.WriteLine("Продукты отсортированы по цене:");
        DisplayAll();
    }

    /// <summary>
    /// Перегрузка операции сложения для подсчета общей стоимости продуктов двух складов.
    /// </summary>
    /// <param name="a">Первый склад.</param>
    /// <param name="b">Второй склад.</param>
    /// <returns>Общая стоимость всех продуктов на двух складах.</returns>
    public static double operator +(Warehouse a, Warehouse b)
    {
        return a.products.Sum(p => p.Price) + b.products.Sum(p => p.Price);
    }

    /// <summary>
    /// Вывод всех продуктов на экран.
    /// </summary>
    public void DisplayAll()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

/// <summary>
/// Главный класс программы, выполняющий операции над складами и продуктами.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Создает продукты, склады и выполняет операции над ними.
    /// </summary>
    static void Main()
    {
        // Создание продуктов
        Product[] initialProducts1 = {
            new Product("Television", "ElectroWorld", 500),
            new Product("Refrigerator", "HomeTech", 800)
        };

        Product[] initialProducts2 = {
            new Product("Phone", "MobileHub", 300),
            new Product("Laptop", "ElectroWorld", 1000)
        };

        // Создание складов
        Warehouse warehouse1 = new Warehouse(initialProducts1);
        Warehouse warehouse2 = new Warehouse(initialProducts2);

        // Вывод изначального списка продуктов
        Console.WriteLine("Исходный список продуктов на складе 1:");
        warehouse1.DisplayAll();
        Console.WriteLine("\nИсходный список продуктов на складе 2:");
        warehouse2.DisplayAll();

        // Подсчет общей стоимости продуктов на двух складах
        double totalCost = warehouse1 + warehouse2;
        Console.WriteLine($"\nОбщая стоимость всех продуктов: ${totalCost:F2}");

        // Сортировка и другие операции
        Console.WriteLine("\nСортировка продуктов по магазину (Склад 1):");
        warehouse1.SortByStore();

        Console.Write("\nВведите индекс продукта (Склад 1): ");
        int index = int.Parse(Console.ReadLine());

        try
        {
            Product product = warehouse1[index];
            Console.WriteLine($"Продукт по индексу {index}: {product}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.Write("\nВведите название продукта для поиска (Склад 2): ");
        string productName = Console.ReadLine();
        warehouse2.FindByName(productName);
    }
}

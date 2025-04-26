using System;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public string Store { get; set; }
    public double Price { get; set; }

    public Product(string name, string store, double price)
    {
        Name = name;
        Store = store;
        Price = price;
    }

    public override string ToString()
    {
        return $"Product: {Name}, Store: {Store}, Price: ${Price:F2}";
    }
}

class Warehouse
{
    private Product[] products;

    public Warehouse(Product[] initialProducts)
    {
        products = initialProducts;
    }

    // Access to products using index
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

    // Method to find a product by name
    public void FindByName(string name)
    {
        var foundProducts = products.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToArray();
        if (foundProducts.Length > 0)
        {
            Console.WriteLine("Found products:");
            foreach (var product in foundProducts)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine($"Product with name \"{name}\" not found.");
        }
    }

    // Sort products by store
    public void SortByStore()
    {
        products = products.OrderBy(p => p.Store).ToArray();
        Console.WriteLine("Products sorted by store:");
        DisplayAll();
    }

    // Sort products by name
    public void SortByName()
    {
        products = products.OrderBy(p => p.Name).ToArray();
        Console.WriteLine("Products sorted by name:");
        DisplayAll();
    }

    // Sort products by price
    public void SortByPrice()
    {
        products = products.OrderBy(p => p.Price).ToArray();
        Console.WriteLine("Products sorted by price:");
        DisplayAll();
    }

    // Overloaded addition operation to sum prices
    public static double operator +(Warehouse a, Warehouse b)
    {
        return a.products.Sum(p => p.Price) + b.products.Sum(p => p.Price);
    }

    // Display all products
    public void DisplayAll()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

class Program
{
    static void Main()
    {
        // Create products
        Product[] initialProducts1 = {
            new Product("Television", "ElectroWorld", 500),
            new Product("Refrigerator", "HomeTech", 800)
        };

        Product[] initialProducts2 = {
            new Product("Phone", "MobileHub", 300),
            new Product("Laptop", "ElectroWorld", 1000)
        };

        // Create warehouses
        Warehouse warehouse1 = new Warehouse(initialProducts1);
        Warehouse warehouse2 = new Warehouse(initialProducts2);

        // Display original list of products
        Console.WriteLine("Original list of products in Warehouse 1:");
        warehouse1.DisplayAll();
        Console.WriteLine("\nOriginal list of products in Warehouse 2:");
        warehouse2.DisplayAll();

        // Overloaded addition operation to sum prices
        double totalCost = warehouse1 + warehouse2;
        Console.WriteLine($"\nTotal cost of all products in both warehouses: ${totalCost:F2}");

        // Sorting and other actions
        Console.WriteLine("\nSorting products by store (Warehouse 1):");
        warehouse1.SortByStore();

        Console.WriteLine("\nEnter the product index (Warehouse 1):");
        int index = int.Parse(Console.ReadLine());

        try
        {
            Product product = warehouse1[index];
            Console.WriteLine($"Product at index {index}: {product}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.Write("\nEnter the product name to search (Warehouse 2): ");
        string productName = Console.ReadLine();
        warehouse2.FindByName(productName);
    }
}

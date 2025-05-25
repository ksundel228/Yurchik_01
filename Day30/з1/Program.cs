using System;
using MySql.Data.MySqlClient;

class Program
{
    static string connectionString = "server=localhost;user=root;password= ;database=DBTur_firm;";

    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1 - Показать все туры");
        Console.WriteLine("2 - Добавить тур");
        Console.WriteLine("3 - Удалить тур");
        Console.WriteLine("4 - Выход");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ShowTours();
                break;
            case "2":
                AddTour();
                break;
            case "3":
                RemoveTour();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Некорректный ввод!");
                break;
        }
    }

    static void ShowTours()
    {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        string query = "SELECT * FROM Тур";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        MySqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine("\nДоступные туры:");
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["ID"]}, Название: {reader["Название"]}, Цена: {reader["Цена"]}, Длительность: {reader["Длительность"]}");
        }
    }

    static void AddTour()
    {
        Console.Write("\nВведите название тура: ");
        string name = Console.ReadLine();
        Console.Write("Введите цену: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.Write("Введите длительность: ");
        int duration = int.Parse(Console.ReadLine());

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        string query = "INSERT INTO Тур (Название, Цена, Длительность) VALUES (@name, @price, @duration)";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@duration", duration);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Тур успешно добавлен!");
    }

    static void RemoveTour()
    {
        Console.Write("\nВведите ID тура для удаления: ");
        int tourId = int.Parse(Console.ReadLine());

        using MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        string query = "DELETE FROM Тур WHERE ID = @id";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", tourId);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Тур успешно удален!");
    }
}

using System;

public class Program
{
    public delegate string StringOperations(string input);

    // Метод для преобразования строки в верхний регистр
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    // Метод для переворота строки
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Метод для подсчёта количества символов в строке
    public static string CountCharacters(string input)
    {
        return $"Количество символов: {input.Length}";
    }

    public static void Main()
    {
        StringOperations operations;

        Console.WriteLine("Введите строку:");
        string userInput = Console.ReadLine();

        operations = ToUpperCase;
        Console.WriteLine($"Результат: {operations(userInput)}");

        operations = ReverseString;
        Console.WriteLine($"Результат: {operations(userInput)}");

        operations = CountCharacters;
        Console.WriteLine($"Результат: {operations(userInput)}");
    }
}

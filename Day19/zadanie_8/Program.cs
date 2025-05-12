using System;

/// <summary>
/// Главный класс программы, выполняющий операции над строками.
/// </summary>
public class Program
{
    /// <summary>
    /// Делегат, представляющий методы обработки строк.
    /// </summary>
    /// <param name="input">Строка для обработки.</param>
    /// <returns>Результат обработки строки.</returns>
    public delegate string StringOperations(string input);

    /// <summary>
    /// Метод преобразует строку в верхний регистр.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Строка в верхнем регистре.</returns>
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    /// <summary>
    /// Метод переворачивает строку задом наперёд.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Перевёрнутая строка.</returns>
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Метод подсчитывает количество символов в строке.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Строка с количеством символов.</returns>
    public static string CountCharacters(string input)
    {
        return $"Количество символов: {input.Length}";
    }

    /// <summary>
    /// Точка входа в программу. Запрашивает у пользователя ввод строки и выполняет её обработку с использованием делегата.
    /// </summary>
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

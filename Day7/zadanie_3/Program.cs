using System;
using System.Text.RegularExpressions;

public class FindAlphanumericWords
{
    public static void Main(string[] args)
    {
        string text = "Это пример текста с alphanumeric словами типа word123, 456 и abc. А вот слова со знаками препинания: hello, world! И с пробелами: some text.  А это кириллица: слово123, слово.";

        string pattern = @"\b[a-zA-Z0-9]+\b"; 

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Найденные слова, состоящие только из букв и цифр:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        Console.ReadKey();
    }
}

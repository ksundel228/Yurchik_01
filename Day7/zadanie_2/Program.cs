using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Текст со \"словом в кавычках\" ";
        
        Regex regex = new Regex(@"""(.*?)""", RegexOptions.IgnoreCase);

        Console.WriteLine("Слова в кавычках:");
        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}

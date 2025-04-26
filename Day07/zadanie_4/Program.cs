using System;
using System.Text.RegularExpressions;

public class FindQUWords
{
    public static void Main(string[] args)
    {
        string text = "This is a text containing words like Quote, quiet, and quagmire, but also queue and quite.  We also have words like Qu, and words like quack.";

        string pattern = @"(?i)\b\w*qu\w*\b";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Найденные слова, в которых буква Q следует за буквой U:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        Console.ReadKey();
    }
}


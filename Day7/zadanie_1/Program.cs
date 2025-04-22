using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "В Интернете есть множество сервисов, которые создают случайный текст - бессмысленный набор случайных слов, которые выглядят как настоящий текст. По отдельности каждое слово что-то означает, но вместе они читаются как ересь.";
        Regex regex = new Regex(@"\b\w*[аеёиоуыэюя]\b", RegexOptions.IgnoreCase);

        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string message = "Привет мир! Как ваши дела?";
        char targetChar = 'а';
        string[] words = message.Split(' ');

        var filteredWords = words.Where(word => !word.ToLower().Contains(char.ToLower(targetChar)));

        string result = string.Join(" ", filteredWords);
        Console.WriteLine(result);
    }
}

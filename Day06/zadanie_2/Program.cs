using System;

class Program
{
    static void Main()
    {
        string message = "Привет мир! Как ваши дела?";
        string[] words = message.Split(new char[] { ' ', '!', '?', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        string result = "";
        foreach (string word in words)
        {
            result += word[word.Length - 1];
        }

        Console.WriteLine(result);
    }
}

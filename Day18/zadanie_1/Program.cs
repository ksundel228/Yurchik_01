using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        string result = ProcessText(input);
        Console.WriteLine("Преобразованная строка: " + result);
    }

    static string ProcessText(string text)
    {
        var stack = new Stack<char>();

        foreach (char c in text)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}

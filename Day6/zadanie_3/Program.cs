using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        // Разделяем предложение на слова
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            // 1. Поменять местами первое и последнее слова
            (words[0], words[words.Length - 1]) = (words[words.Length - 1], words[0]);

            // 2. Склеить второе и третье слова
            string combinedSecondAndThird = words[1] + words[2];

            // 3. Третье слово в обратном порядке
            string thirdWordReversed = ReverseString(words[2]);

            // 4. В первом слове вырезать первые две буквы
            string firstWordTrimmed = words[0].Length > 2 ? words[0][2..] : "";

            // Вывод результатов
            Console.WriteLine("1. Первое и последнее слова поменяны местами: " + string.Join(" ", words));
            Console.WriteLine("2. Второе и третье слова склеены: " + combinedSecondAndThird);
            Console.WriteLine("3. Третье слово в обратном порядке: " + thirdWordReversed);
            Console.WriteLine("4. Первое слово без первых двух букв: " + firstWordTrimmed);
        }
        else
        {
            Console.WriteLine("В предложении должно быть как минимум три слова!");
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

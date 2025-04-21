using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите Фамилию, Имя и Отчество:");
        string? fullName = Console.ReadLine();

        if (string.IsNullOrEmpty(fullName))
        {
            Console.WriteLine("Ошибка: Введена пустая строка.");
            return;
        }

        int personalityCode = CalculateCode(fullName);
        Console.WriteLine($"Код личности: {personalityCode}");
    }

    static int CalculateCode(string input)
    {
        int sum = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (c >= 'а' && c <= 'я') // Для русских букв
                {
                    sum += c - 'а' + 1;
                }
                else if (c >= 'a' && c <= 'z') // Для латинских букв
                {
                    sum += c - 'a' + 1;
                }
            }
        }

        // Приводим сумму к однозначному числу
        while (sum >= 10)
        {
            int tempSum = 0;
            while (sum > 0)
            {
                tempSum += sum % 10;
                sum /= 10;
            }
            sum = tempSum;
        }

        return sum;
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четырёхзначное число:");
        int number = int.Parse(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Ошибка: необходимо ввести четырёхзначное число.");
            return;
        }

        int firstDigit = number / 1000;               // Первая цифра
        int secondDigit = (number / 100) % 10;        // Вторая цифра
        int lastTwoDigits = number % 100;             // Последние две цифры

        int newNumber = secondDigit * 1000 + firstDigit * 100 + lastTwoDigits;

        Console.WriteLine($"Новое число: {newNumber}");
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка, что число является трехзначным
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Число должно быть трехзначным.");
            return;
        }

        // Разделение числа на цифры
        int a = number / 100;         // Первая цифра
        int b = (number / 10) % 10;  // Вторая цифра
        int c = number % 10;         // Третья цифра

        // Проверка на геометрическую прогрессию: b^2 == a * c
        if (b * b == a * c)
        {
            Console.WriteLine("Цифры числа образуют геометрическую прогрессию.");
        }
        else
        {
            Console.WriteLine("Цифры числа не образуют геометрическую прогрессию.");
        }
    }
}

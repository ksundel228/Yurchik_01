//написать программу, определяющую сколько раз цифра К входит в десятичную запись заданного числа n.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число n:");
        int n = Math.Abs(int.Parse(Console.ReadLine())); // Берем абсолютное значение числа
        Console.WriteLine("Введите цифру k (0-9):");
        int k = int.Parse(Console.ReadLine());

        if (k < 0 || k > 9)
        {
            Console.WriteLine("Ошибка: k должна быть цифрой от 0 до 9.");
            return;
        }

        int count = 0;

        while (n > 0)
        {
            int digit = n % 10; // Последняя цифра числа
            if (digit == k)
            {
                count++;
            }
            n /= 10; // Удаляем последнюю цифру
        }

        Console.WriteLine($"Цифра {k} встречается {count} раз(а) в числе.");
    }
}

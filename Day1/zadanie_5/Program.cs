using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число:");
        int number = int.Parse(Console.ReadLine());

        // Проверка, что число действительно трехзначное
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Число должно быть трехзначным!");
            return;
        }

        // Извлечение первой и второй цифры
        int firstDigit = number / 100; // первая цифра
        int secondDigit = (number / 10) % 10; // вторая цифра

        // Сравнение первой и второй цифр
        if (firstDigit > secondDigit)
        {
            Console.WriteLine($"Первая цифра ({firstDigit}) больше второй ({secondDigit}).");
        }
        else if (firstDigit < secondDigit)
        {
            Console.WriteLine($"Вторая цифра ({secondDigit}) больше первой ({firstDigit}).");
        }
        else
        {
            Console.WriteLine($"Первая и вторая цифры равны ({firstDigit}).");
        }
    }
}

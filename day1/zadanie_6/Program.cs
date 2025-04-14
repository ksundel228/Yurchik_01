using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 100;
        int lastDigit = number % 10;

        int sum = firstDigit + lastDigit;

        Console.WriteLine($"Сумма первой и последней цифры: {sum}");
    }
}

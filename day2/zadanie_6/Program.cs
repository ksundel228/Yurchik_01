using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер вагона (1-17):");
        int wagonNumber = int.Parse(Console.ReadLine());

        if (wagonNumber >= 1 && wagonNumber <= 17) // Проверка допустимости номера
        {
            if (wagonNumber >= 10 && wagonNumber <= 17) // Купейный вагон
            {
                Console.WriteLine($"Вагон номер {wagonNumber} является купейным.");
            }
            else // Плацкартный вагон
            {
                Console.WriteLine($"Вагон номер {wagonNumber} является плацкартным.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный номер вагона! Пожалуйста, введите номер от 1 до 17.");
        }
    }
}

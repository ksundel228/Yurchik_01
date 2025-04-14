using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два вещественных числа:");
        
        Console.Write("Число A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Число B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double halfSum = (a + b) / 2;
        
        Console.WriteLine($"Полусумма: {halfSum:F3}");
    }
}

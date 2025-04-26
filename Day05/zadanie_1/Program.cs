using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 10, 25, 35, 50, 65, 70, 85, 100, 115, 20, 5, 55, 75, 45, 95 };
        
        // Находим элементы, которые кратны пяти
        var multiplesOfFive = array.Where(x => x % 5 == 0);
        
        // Вычисляем среднее арифметическое
        double average = multiplesOfFive.Average();
        
        Console.WriteLine($"Среднее арифметическое элементов массива, кратных пяти: {average}");
    }
}

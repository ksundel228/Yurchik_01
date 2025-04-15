using System;

class Program
{
    static void Main()
    {
        // Ввод стоимости компонентов
        Console.Write("Введите стоимость монитора: ");
        decimal monitorPrice = decimal.Parse(Console.ReadLine());
        
        Console.Write("Введите стоимость системного блока: ");
        decimal systemUnitPrice = decimal.Parse(Console.ReadLine());
        
        Console.Write("Введите стоимость клавиатуры: ");
        decimal keyboardPrice = decimal.Parse(Console.ReadLine());
        
        Console.Write("Введите стоимость мыши: ");
        decimal mousePrice = decimal.Parse(Console.ReadLine());
        
        // Вычисление стоимости одного компьютера
        decimal singleComputerPrice = monitorPrice + systemUnitPrice + keyboardPrice + mousePrice;

        // Стоимость трех компьютеров
        int count3 = 3;
        decimal totalPriceFor3 = singleComputerPrice * count3;
        Console.WriteLine($"Стоимость трех компьютеров: {totalPriceFor3}");

        // Ввод количества компьютеров
        Console.Write("Введите количество компьютеров (N): ");
        int numberOfComputers = int.Parse(Console.ReadLine());
        
        // Вычисление стоимости N компьютеров
        decimal totalPriceForN = singleComputerPrice * numberOfComputers;
        Console.WriteLine($"Стоимость {numberOfComputers} компьютеров: {totalPriceForN}");
    }
}

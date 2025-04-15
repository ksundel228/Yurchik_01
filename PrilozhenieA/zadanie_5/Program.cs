using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Задание культуры для обработки чисел с точкой
        CultureInfo culture = CultureInfo.InvariantCulture;

        try
        {
            Console.WriteLine("Введите расстояние до дачи (в километрах):");
            double distanceToDacha = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("Введите расход бензина (литров на 100 км пробега):");
            double fuelConsumption = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("Введите цену одного литра бензина (руб.):");
            double fuelPrice = double.Parse(Console.ReadLine(), culture);

            // Расчет стоимости поездки (туда и обратно)
            double totalDistance = 2 * distanceToDacha; // Расстояние туда и обратно
            double fuelNeeded = (totalDistance / 100) * fuelConsumption; // Объем топлива
            double tripCost = fuelNeeded * fuelPrice; // Итоговая стоимость

            Console.WriteLine($"Поездка на дачу и обратно обойдется в {tripCost:F2} руб.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введенные данные имеют некорректный формат. Используйте точку в качестве разделителя.");
        }
    }
}

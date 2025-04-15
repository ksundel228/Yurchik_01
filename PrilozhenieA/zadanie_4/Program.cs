using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите скорость лодки в стоячей воде (v, км/ч):");
        double v = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите скорость течения реки (v1, км/ч):");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите время движения по озеру (t1, ч):");
        double t1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите время движения против течения реки (t2, ч):");
        double t2 = double.Parse(Console.ReadLine());

        // путь по озеру
        double S_lake = v * t1;

        // путь против течения реки
        double S_river = (v - v1) * t2;

        // путь лодки
        double S_total = S_lake + S_river;

        Console.WriteLine($"Путь, пройденный лодкой по озеру: {S_lake:F2} км");
        Console.WriteLine($"Путь, пройденный лодкой против течения реки: {S_river:F2} км");
        Console.WriteLine($"Общий путь лодки: {S_total:F2} км");
    }
}

using System;

public class Clothing
{
    public string Name { get; set; }
    public Clothing(string name) 
    {
        Name = name;
    }

    public virtual void DisplayCalculation()
    {
        Console.WriteLine($"Одежда: {Name}");
    }
}

public class Coat : Clothing
{
    public double SizeV { get; set; }
    public Coat(string name, double sizeV) : base(name)
    {
        SizeV = sizeV;
    }

    public override void DisplayCalculation()
    {
        double fabricConsumption = SizeV / 6.5 + 0.5;
        Console.WriteLine($"Одежда: {Name}, Размер: {SizeV}, Расход ткани: {fabricConsumption:F2}");
    }
}

public class Suit : Clothing
{
    public double HeightH { get; set; }
    public Suit(string name, double heightH) : base(name)
    {
        HeightH = heightH;
    }

    public override void DisplayCalculation()
    {
        double fabricConsumption = 2 * HeightH + 0.3;
        Console.WriteLine($"Одежда: {Name}, Рост: {HeightH}, Расход ткани: {fabricConsumption:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        Clothing[] clothes = new Clothing[5];
        clothes[0] = new Coat("Пальто", 48);
        clothes[1] = new Coat("Пальто", 52);
        clothes[2] = new Suit("Костюм", 1.8);
        clothes[3] = new Suit("Костюм", 1.7);
        clothes[4] = new Coat("Пальто", 50);

        foreach (var clothing in clothes)
        {
            clothing.DisplayCalculation();
        }
    }
}

using System;

class A
{
    public int a { get; set; }
    public int b { get; set; }

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double CalculateExpression()
    {
        if (a + 2 == 0)
        {
            throw new DivideByZeroException("Знаменатель равен нулю!");
        }
        return (4.0 / (a + 2)) * b;
    }

    public double CalculatePower()
    {
        return Math.Pow(b, 10);
    }
}

class Program
{
    static void Main()
    {

        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        A obj = new A(a, b);

        try
        {
            Console.WriteLine("Значение выражения (4 / (a + 2)) * b: " + obj.CalculateExpression());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при вычислении выражения: " + ex.Message);
        }

        Console.WriteLine("Значение b^10: " + obj.CalculatePower());
    }
}


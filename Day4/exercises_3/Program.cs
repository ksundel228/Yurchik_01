static void genException()
{
    Console.WriteLine("a=");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("b=");
    double b = double.Parse(Console.ReadLine());
    int f = 1;

    try
    {
        for (double i = a; i <= b; ++i)
        {
            try
            {
                f = checked((int)(f * i));

                if (Math.Abs(f - 1) < 0.000001)
                {
                    throw new DivideByZeroException("Результат близок к делению на 0!");
                }

                Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"y({i})=Ошибка: {ex.Message}");
            }
        }
    }
    catch (ArithmeticException)
    {
        Console.WriteLine("ERROR");
        throw;
    }
}




//Ответ
//Исключение DivideByZeroException не возникло, потому что проверка деления на ноль уже была предусмотрена в коде.
//Конкретно, выражение 100 / (f - 1) будет вызывать DivideByZeroException, только если f - 1 равно ровно 0.
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.WriteLine("Введите два числа");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"{a}/{b}={a / b}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Нужно ввести число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на нуль нельзя!");
            }
            catch
            {
                Console.WriteLine("Какая-то ошибка");
            }
            finally
            {
                Console.WriteLine("после try-блока");
            }
        }
    }
}


// когда a=4, b=2, результат: 4/2=2    после try-блока
// когда a=3, b=g, результат: Нужно ввести число!    после try-блока
// когда a=d, b=1, результат: Нужно ввести число!    после try-блока
// когда a=2, b=0, результат: Делить на нуль нельзя!    после try-блока
// когда a=123456789987654321, b=1, результат: Какая-то ошибка    после try-блока

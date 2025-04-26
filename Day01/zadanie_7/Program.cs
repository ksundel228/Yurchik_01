using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите тип цикла: ");
        Console.WriteLine("1 - while");
        Console.WriteLine("2 - do while");
        Console.WriteLine("3 - for");
        Console.Write("Введите номер выбора: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: // Цикл while
                Console.WriteLine("Вы выбрали цикл while.");
                int numberWhile = 100;
                while (numberWhile <= 999)
                {
                    int firstDigit = numberWhile / 100;
                    int secondDigit = (numberWhile / 10) % 10;
                    int thirdDigit = numberWhile % 10;

                    if (firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit)
                    {
                        Console.WriteLine(numberWhile);
                    }

                    numberWhile++;
                }
                break;

            case 2: // Цикл do while
                Console.WriteLine("Вы выбрали цикл do while.");
                int numberDoWhile = 100;
                do
                {
                    int firstDigit = numberDoWhile / 100;
                    int secondDigit = (numberDoWhile / 10) % 10;
                    int thirdDigit = numberDoWhile % 10;

                    if (firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit)
                    {
                        Console.WriteLine(numberDoWhile);
                    }

                    numberDoWhile++;
                } while (numberDoWhile <= 999);
                break;

            case 3: // Цикл for
                Console.WriteLine("Вы выбрали цикл for.");
                for (int numberFor = 100; numberFor <= 999; numberFor++)
                {
                    int firstDigit = numberFor / 100;
                    int secondDigit = (numberFor / 10) % 10;
                    int thirdDigit = numberFor % 10;

                    if (firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit)
                    {
                        Console.WriteLine(numberFor);
                    }
                }
                break;

            default:
                Console.WriteLine("Некорректный выбор. Пожалуйста, выберите 1, 2 или 3.");
                break;
        }
    }
}

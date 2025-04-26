using System;

class Program
{
    // Метод для подсчета количества цифр и их суммы
    static void DigitCountSum(int K, out int C, out int S)
    {
        if (K <= 0)
        {
            throw new ArgumentException("Число K должно быть положительным.");
        }

        C = 0; // Количество цифр
        S = 0; // Сумма цифр

        while (K > 0)
        {
            int digit = K % 10; // Получение последней цифры
            S += digit;         // Добавление цифры к сумме
            C++;                // Увеличение счетчика
            K /= 10;            // Удаление последней цифры
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите 5 положительных целых чисел:");
            
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Число {i}: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new FormatException("Ввод не может быть пустым. Введите корректное число.");
                }

                int K = int.Parse(input);

                int count, sum;
                DigitCountSum(K, out count, out sum);

                Console.WriteLine($"Для числа {K}: Количество цифр = {count}, Сумма цифр = {sum}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
        }
    }
}

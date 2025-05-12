using System;
using System.Threading.Tasks;

class Program
{
    // Метод для вычисления суммы первой и последней цифры трехзначного числа
    static int SumFirstAndLastDigit(int number)
    {
        if (number < 100 || number > 999)
            throw new ArgumentException("Число должно быть трехзначным.");

        int firstDigit = number / 100;  // Первая цифра
        int lastDigit = number % 10;    // Последняя цифра

        return firstDigit + lastDigit;
    }

    static void Main()
    {
        int inputNumber = 375; // Пример трехзначного числа

        // Первый объект Task: вычисляет сумму первой и последней цифры
        Task<int> task1 = Task.Run(() => SumFirstAndLastDigit(inputNumber));

        // Второй объект Task: является задачей продолжения, выводит результат task1
        Task task2 = task1.ContinueWith(previousTask =>
        {
            Console.WriteLine($"Сумма первой и последней цифры числа {inputNumber}: {previousTask.Result}");
        });

        // Дождаться завершения всех задач
        Task.WaitAll(task1, task2);
    }
}

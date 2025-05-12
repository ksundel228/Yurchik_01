using System;
using System.Threading.Tasks;

class NumberProcessor
{
    // Метод проверки, является ли число четырехзначным
    static bool IsValidNumber(int number)
    {
        return number >= 1000 && number <= 9999;
    }

    // Метод перестановки первых двух цифр числа
    static int SwapFirstTwoDigits(int number)
    {
        if (!IsValidNumber(number))
        {
            throw new ArgumentException("Число должно быть четырехзначным.");
        }

        string numStr = number.ToString();
        string swappedNumStr = numStr[1].ToString() + numStr[0].ToString() + numStr.Substring(2);

        return int.Parse(swappedNumStr);
    }

    // Метод для запуска задач с различными способами создания Task
    static void RunTasks(int number)
    {
        Task task1 = Task.Run(() => Console.WriteLine($"Task.Run: {SwapFirstTwoDigits(number)}"));
        Task task2 = Task.Factory.StartNew(() => Console.WriteLine($"Task.Factory.StartNew: {SwapFirstTwoDigits(number)}"));
        Task task3 = new Task(() => Console.WriteLine($"New Task.Start: {SwapFirstTwoDigits(number)}"));
        task3.Start();

        Task.WaitAll(task1, task2, task3);
    }

    static void Main()
    {
        int inputNumber = 1234;
        
        try
        {
            RunTasks(inputNumber);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

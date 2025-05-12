using System;

namespace ShiftLeftExample
{
    /// <summary>
    /// Главный класс программы для демонстрации левого циклического сдвига значений.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Процедура выполняет левый циклический сдвиг трех значений.
        /// </summary>
        /// <param name="A">Первое число, которое сдвигается.</param>
        /// <param name="B">Второе число, которое сдвигается.</param>
        /// <param name="C">Третье число, которое сдвигается.</param>
        static void ShiftLeft3(ref double A, ref double B, ref double C)
        {
            double temp = A;
            A = B;
            B = C;
            C = temp;
        }

        /// <summary>
        /// Точка входа в программу. Выполняет тестирование метода ShiftLeft3().
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются).</param>
        static void Main(string[] args)
        {
            // Первый набор чисел
            double A1 = 1.1, B1 = 2.2, C1 = 3.3;

            // Второй набор чисел
            double A2 = 4.4, B2 = 5.5, C2 = 6.6;

            Console.WriteLine("Исходные значения:");
            Console.WriteLine($"Первый набор: A1 = {A1}, B1 = {B1}, C1 = {C1}");
            Console.WriteLine($"Второй набор: A2 = {A2}, B2 = {B2}, C2 = {C2}");

            // Cдвиг для первого набора
            ShiftLeft3(ref A1, ref B1, ref C1);

            // Cдвиг для второго набора
            ShiftLeft3(ref A2, ref B2, ref C2);

            Console.WriteLine("\nПосле левого циклического сдвига:");
            Console.WriteLine($"Первый набор: A1 = {A1}, B1 = {B1}, C1 = {C1}");
            Console.WriteLine($"Второй набор: A2 = {A2}, B2 = {B2}, C2 = {C2}");
        }
    }
}

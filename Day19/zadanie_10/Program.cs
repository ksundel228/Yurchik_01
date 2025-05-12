using System;
using System.IO;

namespace Zadanie2
{
    /// <summary>
    /// Главный класс программы, выполняющий подсчет четных чисел из текстового файла.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу. Считывает числа из файла и подсчитывает количество четных чисел.
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются).</param>
        static void Main(string[] args)
        {
            /// <summary>
            /// Открывает файл "g.txt" для чтения.
            /// </summary>
            FileStream file = new FileStream(@"g.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s;
            int count = 0;

            /// <summary>
            /// Читает строки файла и проверяет, является ли число четным.
            /// </summary>
            while ((s = reader.ReadLine()) != null)
            {
                int num = Convert.ToInt32(s);
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            /// <summary>
            /// Закрывает поток чтения файла.
            /// </summary>
            reader.Close();

            /// <summary>
            /// Выводит количество четных чисел в файле.
            /// </summary>
            Console.WriteLine("Количество четных чисел в файле: {0}", count);
            Console.ReadLine();
        }
    }
}

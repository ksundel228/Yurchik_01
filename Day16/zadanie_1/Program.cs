using System;
using System.IO;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"g.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s;
            int count = 0;

            while ((s = reader.ReadLine()) != null)
            {
                int num = Convert.ToInt32(s);
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            reader.Close();

            Console.WriteLine("Количество четных чисел в файле: {0}", count);
            Console.ReadLine();
        }
    }
}

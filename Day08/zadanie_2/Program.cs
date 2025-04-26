using System;

namespace EmployeeBonus
{
    enum Post
    {
        Manager = 160,
        Developer = 150,
        Designer = 140,
        Tester = 130     
    }

    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accountant = new Accauntant();

            Post[] workers = { Post.Manager, Post.Developer, Post.Designer, Post.Tester };
            int[] workedHours = { 170, 145, 150, 135 };

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Проверка для сотрудника: {workers[i]}");

                if (accountant.AskForBonus(workers[i], workedHours[i]))
                {
                    Console.WriteLine("Сотруднику положена премия!");
                }
                else
                {
                    Console.WriteLine("Сотруднику не положена премия.");
                }

                Console.WriteLine();
            }
        }
    }
}

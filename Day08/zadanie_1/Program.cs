namespace _1
{
    class Program
    {
        struct ZNAK
        {
            public string name, surname;
            public string zodiacSign;
            public int[] birthday;
        }
        static void Main(string[] args)
        {
            ZNAK[] mass = new ZNAK[8];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("Введите имя:");
                mass[i].name = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Введите фамилию:");
                mass[i].surname = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Введите знак Зодиака:");
                mass[i].zodiacSign = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Введите дату рождения (день, месяц, год):");
                mass[i].birthday = new int[3];
                for (int j = 0; j < mass[i].birthday.Length; j++)
                {
                    string input = Console.ReadLine() ?? "0";
                    if (!int.TryParse(input, out mass[i].birthday[j]))
                    {
                        Console.WriteLine("Ошибка: введите корректное число!");
                        j--;
                    }
                }
            }
            Sort(mass);

            Console.WriteLine("Введите знак Зодиака для поиска:");
            string searchZodiacSign = Console.ReadLine() ?? string.Empty;
            bool found = false;

            foreach (var person in mass)
            {
                if (person.zodiacSign.Equals(searchZodiacSign, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Имя: " + person.name);
                    Console.WriteLine("Фамилия: " + person.surname);
                    Console.WriteLine("Знак Зодиака: " + person.zodiacSign);
                    Console.WriteLine("Дата рождения: " + string.Join(".", person.birthday));
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Человек с таким знаком Зодиака не найден.");
            }
        }

        static bool isMin(ZNAK first, ZNAK second)
        {
            if (first.birthday[2] < second.birthday[2]) return false;
            else if (first.birthday[2] > second.birthday[2]) return true;
            else if (first.birthday[1] < second.birthday[1]) return false;
            else if (first.birthday[1] > second.birthday[1]) return true;
            else if (first.birthday[0] < second.birthday[0]) return false;
            else if (first.birthday[0] > second.birthday[0]) return true;
            else return false;
        }

        static void Sort(ZNAK[] mass)
        {
            ZNAK buf;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (isMin(mass[i], mass[j]))
                    {
                        buf = mass[i];
                        mass[i] = mass[j];
                        mass[j] = buf;
                    }
                }
            }
        }
    }
}

using System;

namespace Zadanie2
{
    // Класс A
    class A
    {
        private int a; // Поле a
        private int b; // Поле b

        // Свойство c: сумма полей a и b
        public int C
        {
            get { return a + b; }
        }

        // Конструктор по умолчанию
        public A()
        {
            a = 5; // Инициализация поля a
            b = 10; // Инициализация поля b
        }
    }

    // Класс B (наследник A)
    class B : A
    {
        private int d; // Поле d

        // Свойство c2: произведение полей a, b, и d с использованием оператора while
        public int C2
        {
            get
            {
                int result = 1;
                int counter = 0;

                while (counter < d)
                {
                    result *= C; // C - свойство из родительского класса
                    counter++;
                }

                return result;
            }
        }

        // Конструктор, наследующийся от класса A
        public B() : base()
        {
            d = 3; // Инициализация поля d
        }

        // Собственный конструктор
        public B(int dValue) : base()
        {
            d = dValue;
        }
    }

    // Основной класс Program
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса A
            A objA = new A();
            Console.WriteLine("Свойство c (класс A): {0}\n", objA.C);

            // Создание объекта класса B с использованием наследуемого конструктора
            B objB1 = new B();
            Console.WriteLine("Свойство c2 (класс B, конструктор 1): {0}\n", objB1.C2);

            // Создание объекта класса B с использованием собственного конструктора
            B objB2 = new B(5);
            Console.WriteLine("Свойство c2 (класс B, конструктор 2): {0}\n", objB2.C2);

            Console.ReadLine();
        }
    }
}

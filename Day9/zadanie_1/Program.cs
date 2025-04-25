using System;

namespace InterfaceExample
{
    // Определение интерфейсов
    interface Ix
    {
        void IxF0(double w);
        void IxF1();
    }

    interface Iy
    {
        void F0(double w);
        void F1();
    }

    interface Iz
    {
        void F0(double w);
        void F1();
    }

    // Класс TestClass, наследующий интерфейсы
    class TestClass : Ix, Iy, Iz
    {
        public double w;

        // Конструктор
        public TestClass(double value)
        {
            w = value;
        }

        // Реализация интерфейса Ix
        public void IxF0(double w)
        {
            this.w = Math.Cos(w); // Возвращает cos(w)
            Console.WriteLine($"IxF0: Cos(w) = {this.w}");
        }

        public void IxF1()
        {
            this.w = Math.Exp(w); // Возвращает exp(w)
            Console.WriteLine($"IxF1: Exp(w) = {this.w}");
        }

        // Неявная реализация интерфейсов Iy
        public void F0(double w)
        {
            this.w = Math.Cos(w); // Возвращает cos(w)
            Console.WriteLine($"(Iy) F0: Cos(w) = {this.w}");
        }

        public void F1()
        {
            this.w = Math.Exp(w); // Возвращает exp(w)
            Console.WriteLine($"(Iy) F1: Exp(w) = {this.w}");
        }

        // Явная реализация интерфейса Iz
        void Iz.F0(double w)
        {
            this.w = 1 / Math.Exp(w); // Возвращает 1/exp(w)
            Console.WriteLine($"Iz.F0: 1/Exp(w) = {this.w}");
        }

        void Iz.F1()
        {
            this.w = 1 / Math.Cos(w); // Возвращает 1/cos(w)
            Console.WriteLine($"Iz.F1: 1/Cos(w) = {this.w}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта TestClass
            TestClass test = new TestClass(2.0);

            // Вызов методов интерфейса Ix
            test.IxF0(2.0);
            test.IxF1();

            // Вызов методов интерфейсов Iy (неявная реализация)
            test.F0(2.0);
            test.F1();

            // Вызов методов интерфейса Iz через явное приведение
            Iz iz = test;
            iz.F0(2.0);
            iz.F1();
        }
    }
}

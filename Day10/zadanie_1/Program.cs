namespace Zadanie1
{
    // Класс Apartment (Квартира)
    class Apartment
    {
        private string name;       // Название квартиры
        private double costPerM2; // Стоимость 1 м²
        private double area;      // Площадь

        // Конструктор с параметрами
        public Apartment(string name, double costPerM2, double area)
        {
            this.name = name;
            this.costPerM2 = costPerM2;
            this.area = area;
        }

        // Метод для расчета стоимости квартиры
        public virtual double CalculateCost()
        {
            return costPerM2 * area;
        }

        // Методы доступа
        public string Name { get { return name; } set { name = value; } }
        public double CostPerM2 { get { return costPerM2; } set { costPerM2 = value; } }
        public double Area { get { return area; } set { area = value; } }

        // Метод для вывода информации о квартире
        public void GetInfo()
        {
            Console.WriteLine("Название: {0} | Стоимость 1м²: {1} | Площадь: {2}", name, costPerM2, area);
        }
    }

    // Класс CenterApartment (Квартира в центре), наследник Apartment
    class CenterApartment : Apartment
    {
        private string district; // Название района

        // Конструктор с параметрами
        public CenterApartment(string name, double costPerM2, double area, string district)
            : base(name, costPerM2, area)
        {
            this.district = district;
        }

        // Переопределение метода для расчета стоимости
        public override double CalculateCost()
        {
            double baseCost = base.CalculateCost();
            return baseCost + (baseCost * 0.01); // Надбавка за расположение
        }

        // Метод для вывода информации о квартире в центре
        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Район: {0} | Общая стоимость (с надбавкой): {1}", district, CalculateCost());
        }
    }

    // Основной класс Program
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта базового типа
            Apartment apartment = new Apartment("Обычная квартира", 1000, 50);
            apartment.GetInfo();
            Console.WriteLine("Стоимость квартиры: {0}\n", apartment.CalculateCost());

            // Создание объекта производного типа
            CenterApartment centerApartment = new CenterApartment("Квартира в центре", 1500, 60, "Центральный район");
            centerApartment.GetInfo();

            Console.ReadLine();
        }
    }
}

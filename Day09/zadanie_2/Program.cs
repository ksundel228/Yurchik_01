using System;

namespace ParkingSystem
{
    // Класс, представляющий информацию об автомобиле
    class Car : IComparable<Car>
    {
        public string LicensePlate { get; set; } // Госномер
        public string Color { get; set; } // Цвет
        public string OwnerLastName { get; set; } // Фамилия владельца
        public bool IsPresent { get; set; } // Признак присутствия на стоянке

        // Реализация интерфейса IComparable
        public int CompareTo(Car other)
        {
            return string.Compare(this.LicensePlate, other.LicensePlate, StringComparison.Ordinal);
        }

        // Перегрузка операций отношения
        public static bool operator <(Car c1, Car c2) => c1.CompareTo(c2) < 0;
        public static bool operator >(Car c1, Car c2) => c1.CompareTo(c2) > 0;
        public static bool operator ==(Car c1, Car c2) => c1.CompareTo(c2) == 0;
        public static bool operator !=(Car c1, Car c2) => !(c1 == c2);
        public static bool operator <=(Car c1, Car c2) => c1.CompareTo(c2) <= 0;
        public static bool operator >=(Car c1, Car c2) => c1.CompareTo(c2) >= 0;

        public override bool Equals(object obj)
        {
            if (obj is Car other)
            {
                return this.LicensePlate == other.LicensePlate;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return LicensePlate.GetHashCode();
        }
    }

    // Класс "Автостоянка"
    class ParkingLot
    {
        private Car[] parkingSpaces; // Массив автомобилей
        private int count; // Количество занятых мест

        public ParkingLot(int size)
        {
            parkingSpaces = new Car[size];
            count = 0;
        }

        // Добавление автомобиля на стоянку
        public void AddCar(int spaceNumber, Car car)
        {
            if (spaceNumber >= 0 && spaceNumber < parkingSpaces.Length)
            {
                if (parkingSpaces[spaceNumber] == null)
                {
                    parkingSpaces[spaceNumber] = car;
                    count++;
                    Console.WriteLine($"Машина с госномером {car.LicensePlate} добавлена на место {spaceNumber}.");
                }
                else
                {
                    Console.WriteLine($"Место {spaceNumber} уже занято!");
                }
            }
            else
            {
                Console.WriteLine("Некорректный номер места!");
            }
        }

        // Поиск автомобиля по различным критериям
        public Car[] SearchCars(Func<Car, bool> criteria)
        {
            return Array.FindAll(parkingSpaces, car => car != null && criteria(car));
        }

        // Вывод списка присутствующих автомобилей
        public Car[] GetPresentCars()
        {
            return SearchCars(car => car.IsPresent);
        }

        // Вывод списка отсутствующих автомобилей
        public Car[] GetAbsentCars()
        {
            return SearchCars(car => !car.IsPresent);
        }

        // Получение информации о машине по номеру места
        public Car GetCarBySpace(int spaceNumber)
        {
            return (spaceNumber >= 0 && spaceNumber < parkingSpaces.Length) ? parkingSpaces[spaceNumber] : null;
        }

        // Вывод информации обо всех автомобилях
        public void DisplayAllCars()
        {
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                var car = parkingSpaces[i];
                if (car != null)
                {
                    Console.WriteLine($"Место: {i}, Госномер: {car.LicensePlate}, Цвет: {car.Color}, " +
                                      $"Владелец: {car.OwnerLastName}, Присутствует: {car.IsPresent}");
                }
            }
        }
    }

    // Основная программа
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество мест на стоянке: ");
            int parkingSize = int.Parse(Console.ReadLine());
            ParkingLot parkingLot = new ParkingLot(parkingSize);

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить машину");
                Console.WriteLine("2. Найти машину по критерию");
                Console.WriteLine("3. Список присутствующих машин");
                Console.WriteLine("4. Список отсутствующих машин");
                Console.WriteLine("5. Информация о машине по номеру места");
                Console.WriteLine("6. Выход");
                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите номер места: ");
                        int spaceNumber = int.Parse(Console.ReadLine());

                        Console.Write("Введите госномер: ");
                        string licensePlate = Console.ReadLine();

                        Console.Write("Введите цвет машины: ");
                        string color = Console.ReadLine();

                        Console.Write("Введите фамилию владельца: ");
                        string ownerLastName = Console.ReadLine();

                        Console.Write("Присутствует на стоянке (true/false): ");
                        bool isPresent = bool.Parse(Console.ReadLine());

                        parkingLot.AddCar(spaceNumber, new Car
                        {
                            LicensePlate = licensePlate,
                            Color = color,
                            OwnerLastName = ownerLastName,
                            IsPresent = isPresent
                        });
                        break;

                    case 2:
                        Console.WriteLine("Введите критерий поиска (1-Госномер, 2-Цвет, 3-Фамилия владельца): ");
                        int searchOption = int.Parse(Console.ReadLine());
                        Console.Write("Введите значение для поиска: ");
                        string searchValue = Console.ReadLine();

                        Car[] foundCars = searchOption switch
                        {
                            1 => parkingLot.SearchCars(car => car.LicensePlate == searchValue),
                            2 => parkingLot.SearchCars(car => car.Color == searchValue),
                            3 => parkingLot.SearchCars(car => car.OwnerLastName == searchValue),
                            _ => new Car[0]
                        };

                        Console.WriteLine("Найденные машины:");
                        foreach (var car in foundCars)
                        {
                            Console.WriteLine($"Госномер: {car.LicensePlate}, Цвет: {car.Color}, Владелец: {car.OwnerLastName}, Присутствует: {car.IsPresent}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Присутствующие машины:");
                        foreach (var car in parkingLot.GetPresentCars())
                        {
                            Console.WriteLine($"Госномер: {car.LicensePlate}, Цвет: {car.Color}, Владелец: {car.OwnerLastName}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Отсутствующие машины:");
                        foreach (var car in parkingLot.GetAbsentCars())
                        {
                            Console.WriteLine($"Госномер: {car.LicensePlate}, Цвет: {car.Color}, Владелец: {car.OwnerLastName}");
                        }
                        break;

                    case 5:
                        Console.Write("Введите номер места: ");
                        int number = int.Parse(Console.ReadLine());
                        var carAtSpace = parkingLot.GetCarBySpace(number);
                        if (carAtSpace != null)
                        {
                            Console.WriteLine($"Госномер: {carAtSpace.LicensePlate}, Цвет: {carAtSpace.Color}, Владелец: {carAtSpace.OwnerLastName}, Присутствует: {carAtSpace.IsPresent}");
                        }
                        else
                        {
                            Console.WriteLine("На данном месте нет автомобиля.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Выход из программы...");
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}

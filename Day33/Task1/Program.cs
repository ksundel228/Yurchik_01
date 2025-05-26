using System; // Подключение пространства имен для базовых классов и методов
using System.Collections.Generic; // Подключение пространства имен для работы с коллекциями
using System.Threading.Tasks; // Подключение пространства имен для работы с асинхронным программированием
using Task1.Contexts; // Подключение пространства имен для контекста базы данных
using Task1.Models; // Подключение пространства имен для моделей данных

namespace Task1
{
    class Program
    {
        // Асинхронный метод Main - точка входа в программу
        static async Task Main(string[] args)
        {
            // Путь к базе данных
            string dbPath = @"..\..\..\Database\DBTur_firm.db";
            // Создание экземпляра контекста базы данных
            TouristContext dbContext = new TouristContext(dbPath);

            // Создание нового туриста
            Tourist newTourist = CreateTourist();

            // Добавление нового туриста в базу данных
            int addResult = await dbContext.AddTouristAsync(newTourist);
            if (addResult > 0)
            {
                // Уведомление об успешном добавлении туриста
                Console.WriteLine($"Турист добавлен.");
            }
            else
            {
                // Уведомление о неудачном добавлении туриста
                Console.WriteLine($"Турист не добавлен.");
            }

            // Получение списка всех туристов из базы данных
            List<Tourist> tourists = await dbContext.GetTouristsAsync();
            // Вывод списка туристов
            Console.WriteLine("Список туристов:");
            PrintTourists(tourists);

            // Проверка, есть ли туристы в списке
            if (tourists.Count > 0)
            {
                // Запрос у пользователя выбора туриста для удаления
                Console.WriteLine("Выберите туриста для удаления:");
                int touristIdToDelete = int.Parse(Console.ReadLine());
                // Удаление выбранного туриста из базы данных
                int deleteResult = await dbContext.DeleteTouristAsync(touristIdToDelete);
                if (deleteResult > 0)
                {
                    // Уведомление об успешном удалении туриста
                    Console.WriteLine($"Турист удален.");
                }
                else
                {
                    // Уведомление о неудачном удалении туриста
                    Console.WriteLine($"Турист не найден.");
                }
            }

            // Повторное получение списка всех туристов из базы данных
            tourists = await dbContext.GetTouristsAsync();
            // Повторный вывод списка туристов
            Console.WriteLine("Список туристов:");
            PrintTourists(tourists);
        }

        // Метод для создания нового туриста с вводом данных от пользователя
        static Tourist CreateTourist()
        {
            // Запрос ввода фамилии туриста
            Console.WriteLine("Введите фамилию туриста:");
            string lastName = Console.ReadLine();

            // Запрос ввода имени туриста
            Console.WriteLine("Введите имя туриста:");
            string firstName = Console.ReadLine();

            // Запрос ввода отчества туриста
            Console.WriteLine("Введите отчество туриста:");
            string patronymic = Console.ReadLine();

            // Создание нового туриста с введенными данными
            Tourist newTourist = new Tourist
            {
                LastName = lastName,
                FirstName = firstName,
                Patronymic = patronymic
            };

            return newTourist; // Возвращение нового туриста
        }

        // Метод для вывода списка туристов на консоль
        static void PrintTourists(List<Tourist> tourists)
        {
            foreach (var tourist in tourists) // Цикл по каждому туристу в списке
            {
                // Вывод данных туриста на консоль
                Console.WriteLine($"ID: {tourist.TouristId}, ФИО: {tourist.LastName} {tourist.FirstName} {tourist.Patronymic}");
            }
        }
    }
}

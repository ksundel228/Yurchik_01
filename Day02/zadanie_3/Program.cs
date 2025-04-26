using System;

namespace FileExample
{
    // Класс Файл
    public class File
    {
        // Свойства
        public string FileName { get; private set; }
        public DateTime CreationDate { get; private set; }
        public long FileLength { get; private set; }

        // Конструктор с проверкой допустимости значений
        public File(string fileName, DateTime creationDate, long fileLength)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Имя файла не может быть пустым.");

            if (fileLength < 0)
                throw new ArgumentException("Длина файла не может быть отрицательной.");

            FileName = fileName;
            CreationDate = creationDate;
            FileLength = fileLength;
        }

        // Метод добавления информации в конец файла
        public void AppendData(long additionalLength)
        {
            if (additionalLength < 0)
                throw new ArgumentException("Добавляемая длина не может быть отрицательной.");

            FileLength += additionalLength;
        }

        // Метод получения информации о состоянии файла
        public string GetFileInfo()
        {
            return $"Имя файла: {FileName}, Дата создания: {CreationDate}, Длина файла: {FileLength} байт.";
        }
    }

    // Программа для демонстрации
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Инициализация файла
                Console.WriteLine("Введите имя файла:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Введите дату создания файла (в формате ГГГГ-ММ-ДД):");
                DateTime creationDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину файла:");
                long fileLength = long.Parse(Console.ReadLine());

                File file = new File(fileName, creationDate, fileLength);

                // Вывод информации о файле
                Console.WriteLine("\nСостояние файла:");
                Console.WriteLine(file.GetFileInfo());

                // Добавление информации в конец файла
                Console.WriteLine("\nВведите количество байтов для добавления в файл:");
                long additionalLength = long.Parse(Console.ReadLine());
                file.AppendData(additionalLength);

                // Вывод обновленной информации о файле
                Console.WriteLine("\nОбновленное состояние файла:");
                Console.WriteLine(file.GetFileInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

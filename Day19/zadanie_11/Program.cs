using System;
using System.IO;

/// <summary>
/// Главный класс программы, выполняющий создание новой папки.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Создает указанную папку и выводит сообщение о ее создании.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к создаваемой папке. Необходимо указать актуальный путь.
        /// </summary>
        string folderPath = @"D:\3 курс\Практика C#\Day19\zadanie_1\New_folder"; // Укажите нужный путь

        /// <summary>
        /// Создает папку по указанному пути. Если папка уже существует, метод не выполняет никаких действий.
        /// </summary>
        Directory.CreateDirectory(folderPath); 

        /// <summary>
        /// Выводит сообщение о создании папки.
        /// </summary>
        Console.WriteLine("Папка успешно создана: " + folderPath);
        Console.ReadLine();
    }
}

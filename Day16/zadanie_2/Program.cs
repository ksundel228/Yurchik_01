using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"D:\3 курс\Практика C#\Day16\zadanie_1\New_folder"; // Укажите нужный путь
        Directory.CreateDirectory(folderPath); // Создание папки

        Console.WriteLine("Папка успешно создана: " + folderPath);
        Console.ReadLine();
    }
}

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1 // ❗️ Убедись, что имя совпадает с `Form1.cs`
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа в приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ✅ Запускаем `Form1`
        }
    }
}


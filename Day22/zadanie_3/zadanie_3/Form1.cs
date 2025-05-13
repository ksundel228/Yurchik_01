using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем x0, xk, dx, b
                double x0 = Convert.ToDouble(txtX0.Text);
                double xk = Convert.ToDouble(txtXk.Text);
                double dx = Convert.ToDouble(txtDx.Text);
                double b = Convert.ToDouble(txtB.Text);

                txtResults.Text = "Таблица значений функции:\n";

                // Цикл табулирования
                for (double x = x0; x <= xk; x += dx)
                {
                    double y;

                    // Разветвление: меняем метод вычисления
                    if (x < 1)
                    {
                        y = Math.Sin(x);
                    }
                    else if (x >= 1 && x <= 4)
                    {
                        y = Math.Cos(x);
                    }
                    else
                    {
                        y = (Math.Pow(x, 5.0 / 2) - b) * Math.Log(Math.Pow(x, 2) + 12.7);
                    }

                    // Вывод строки таблицы
                    txtResults.Text += $"x = {x:F2}, y = {y:F5}\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

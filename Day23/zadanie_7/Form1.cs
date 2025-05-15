using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Mas = new int[15]; // Глобальный массив

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Очистка списка
            Random rand = new Random(); // Генератор случайных чисел

            for (int i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-50, 50); // Числа от -50 до 49
                listBox1.Items.Add($"Mas[{i}] = {Mas[i]}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); // Очистка второго списка
            int count = 0;

            foreach (int num in Mas)
            {
                if (num > 0 && num % 2 != 0) // Проверка положительного и нечётного
                {
                    count++;
                    listBox2.Items.Add(num); // Добавляем в ListBox
                }
            }
            MessageBox.Show($"Нечётных положительных чисел: {count}");
        }
    }
}

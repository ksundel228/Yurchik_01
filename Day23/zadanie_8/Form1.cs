using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; // Количество строк
            dataGridView1.ColumnCount = 15; // Количество столбцов

            int[,] matrix = new int[15, 15]; // Инициализация массива
            Random rand = new Random();

            // Заполняем матрицу случайными числами
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100); // Диапазон -100 до 99
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j]; // Заполнение таблицы
                }
            }

            // Сохраняем матрицу в Tag формы (для использования в других методах)
            this.Tag = matrix;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrix = (int[,])this.Tag; // Получаем матрицу
            int minColumn = -1;
            int minCount = int.MaxValue;

            // Перебираем столбцы
            for (int j = 0; j < 15; j++)
            {
                int count = 0;

                for (int i = 0; i < 15; i++)
                {
                    if (matrix[i, j] > 0) count++; // Подсчет положительных элементов
                }

                if (count < minCount) // Проверяем минимальное значение
                {
                    minCount = count;
                    minColumn = j;
                }
            }

            textBox1.Text = $"Столбец: {minColumn} (положительных: {minCount})"; // Вывод результата
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение значений x, y, z из текстовых полей
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                double z = Convert.ToDouble(txtZ.Text);

                // Вычисление формулы g
                double g = (Math.Pow(y, x + 1) / (Math.Pow(Math.Abs(y - 2), 1.0 / 3) + 3))
                         + ((x + (y / 2)) / (2 * Math.Abs(x + y))) * Math.Pow(x + 1, -1.0 / Math.Sin(z));

                // Вывод результата в метку lblResult
                lblResult.Text = $"Результат g: {g:F5}";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода! Проверьте значения x, y, z.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtZ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

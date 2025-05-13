using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zadanie2
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
                // Читаем x, y, z
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                double z = Convert.ToDouble(txtZ.Text);

                // Определяем функцию f(x)
                double fx;
                if (radioSh.Checked) fx = Math.Sinh(x);
                else if (radioX2.Checked) fx = Math.Pow(x, 2);
                else if (radioExp.Checked) fx = Math.Exp(x);
                else throw new Exception("Выберите функцию!");

                // Вычисляем q
                double numerator = Math.Max(fx + y + z, x * y * z);
                double denominator = Math.Min(fx + y + z, x * y * z);
                double q = numerator / denominator;

                // Вывод результата
                lblResult.Text = $"Результат q: {q:F5}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


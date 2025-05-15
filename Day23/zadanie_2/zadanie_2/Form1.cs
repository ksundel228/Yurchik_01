using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_2
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
                // Считываем с формы параметры
                double Xmin = double.Parse(textBoxXmin.Text);
                double Xmax = double.Parse(textBoxXmax.Text);
                double Step = double.Parse(textBoxStep.Text);

                // Вычисляем количество точек
                int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
                double[] x = new double[count];
                double[] y = new double[count];

                // Заполняем массивы X и Y
                for (int i = 0; i < count; i++)
                {
                    x[i] = Xmin + Step * i;
                    y[i] = Math.Sin(x[i]) * Math.Cos(x[i]);
                }

                // Настраиваем оси графика
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

                // Очищаем старые точки графика
                chart1.Series.Clear();
                chart1.Series.Add("sin(x) * cos(x)");
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[0].BorderWidth = 2;
                chart1.Series[0].Color = System.Drawing.Color.Blue;

                // Добавляем точки на график
                chart1.Series[0].Points.DataBindXY(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2;
        private double a, t, fi;
        private Pen pen;
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();

            // Настройка пера для рисования
            pen = new Pen(Color.DarkRed, 2);

            // Центр координат
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;

            // Параметры Декартова листа
            a = 150;
            fi = -0.5;
            t = Math.Tan(fi);

            // Вычисление начальных координат точки
            UpdateCoordinates();

            // Настройка таймера
            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void UpdateCoordinates()
        {
            x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t)); // Минус для направления движения
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            fi += 0.01;
            t = Math.Tan(fi);
            UpdateCoordinates();
            Invalidate(); // Обновляем форму
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Рисуем Декартов лист (только точку)
            g.FillEllipse(Brushes.DarkRed, x2 - 10, y2 - 10, 20, 20);

            // 🔲 Рисуем квадрат (из схемы)
            g.DrawRectangle(Pens.Black, x1 - 75, y1 - 75, 150, 150);

            // 🔹 Рисуем прямую (горизонтальную)
            g.DrawLine(Pens.Blue, x1 - 200, y1, x1 + 200, y1);
        }
    }
}

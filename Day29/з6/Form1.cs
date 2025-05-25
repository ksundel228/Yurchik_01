using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private float angle = -90; 
        private const int centerX = 250;
        private const int centerY = 250;
        private const int radius = 100;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.Invalidate(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 6;
            if (angle >= 270) angle -= 360;
            Console.WriteLine($"Обновленный угол: {angle}");
            this.Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillEllipse(Brushes.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
            g.DrawEllipse(new Pen(Color.Red, 3), centerX - radius, centerY - radius, radius * 2, radius * 2);

            float x2 = centerX + radius * (float)Math.Cos(Math.PI * angle / 180);
            float y2 = centerY + radius * (float)Math.Sin(Math.PI * angle / 180);

            g.DrawLine(new Pen(Color.Red, 3), centerX, centerY, x2, y2);
        }
    }
}

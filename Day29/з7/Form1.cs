using System;
using System.Drawing;
using System.Windows.Forms;

namespace SineWaveAnimation
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int x;
        private int centerY;
        private const int amplitude = 50;
        private const int speed = 5;
        private const int circleRadius = 20;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.White;

            x = 0;
            centerY = this.ClientSize.Height / 2;

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            x += speed;

            if (x > this.ClientSize.Width)
                x = 0;

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int y = centerY + (int)(amplitude * Math.Sin(x * Math.PI / 180));
            g.FillEllipse(Brushes.Red, x - circleRadius / 2, y - circleRadius / 2, circleRadius, circleRadius);
        }
    }
}

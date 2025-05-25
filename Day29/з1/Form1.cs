using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerAnimationApp
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int circleX = 50; 
        private int circleY = 100;
        private int speedX = 5; 
        private int speedY = 2; 

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 

            timer = new Timer();
            timer.Interval = 50; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            circleX += speedX;
            circleY += speedY;

            if (circleX + 50 > this.ClientSize.Width || circleX < 0)
                speedX = -speedX;

            if (circleY + 50 > this.ClientSize.Height || circleY < 0)
                speedY = -speedY; 

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.FillEllipse(Brushes.Red, circleX, circleY, 50, 50);
        }
    }
}

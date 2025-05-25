using System;
using System.Drawing;
using System.Windows.Forms;

namespace з3
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2;
        private double a, t, fi;
        private Pen pen = new Pen(Color.DarkRed, 2);
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            a = 150;
            fi = -0.5;
            t = Math.Tan(fi);
            x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t));

            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            fi += 0.01;
            t = Math.Tan(fi);
            x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t));

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawEllipse(pen, x2, y2, 20, 20);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, x2, y2, 20, 20);
        }

    }
}

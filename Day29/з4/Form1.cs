using System;
using System.Drawing;
using System.Windows.Forms;

namespace з4
{
    public partial class Form1 : Form
    {
        private Bitmap sky, plane;
        private Graphics g;
        private int dx;
        private Rectangle rct;
        private bool demo = true;
        private Random rnd;
        private Timer timer2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sky = new Bitmap("sky.bmp");
                plane = new Bitmap("plane.bmp");
                this.BackgroundImage = sky;

                plane.MakeTransparent();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка загрузки изображений: " + exception.Message,
                                "Полет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.ClientSize = new Size(sky.Width, sky.Height);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            g = CreateGraphics();
            rnd = new Random();

            rct = new Rectangle(-40, 20 + rnd.Next(20), plane.Width, plane.Height);
            dx = 2;

            timer2 = new Timer();
            timer2.Interval = 20;
            timer2.Tick += Timer2_Tick;
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Invalidate();

            if (rct.X < this.ClientRectangle.Width)
            {
                rct.X += dx;
            }
            else
            {
                rct.X = -40;
                rct.Y = 20 + rnd.Next(this.ClientSize.Height - 40 - plane.Height);
                dx = 2 + rnd.Next(4);
            }

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(sky, 0, 0);
            g.DrawImage(plane, rct.X, rct.Y);
        }
    }
}

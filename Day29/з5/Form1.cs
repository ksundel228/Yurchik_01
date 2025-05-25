using System;
using System.Drawing;
using System.Windows.Forms;

namespace RocketLaunchApp
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int rocketY;
        private Bitmap rocket;
        private bool isLaunching = false;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            try
            {
                rocket = new Bitmap("rocket.png"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения ракеты: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            rocketY = ClientSize.Height - rocket.Height;

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rocketY > -rocket.Height)
            {
                rocketY -= 5;
                Invalidate();
            }
            else
            {
                timer.Stop();
                isLaunching = false;
                btnStart.Enabled = true;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            g.DrawImage(rocket, (ClientSize.Width - rocket.Width) / 2, rocketY);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isLaunching)
            {
                isLaunching = true;
                btnStart.Enabled = false; 
                rocketY = ClientSize.Height - rocket.Height; 
                timer.Start();
            }
        }
    }
}

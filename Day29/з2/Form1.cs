using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace з2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle rct;
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();

            try
            {
                baner = new Bitmap("baner.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n " + ex.ToString(), "Баннер");
                this.Close();
                return;
            }

            rct = new Rectangle(0, 0, baner.Width, baner.Height);

            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1;

            if (Math.Abs(rct.X) > rct.Width)
            {
                rct.X += rct.Width;
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;

            // Рисуем баннер
            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(baner, rct.X + i * rct.Width, rct.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                timer1.Enabled = false; 
            }
            else
            {
                timer1.Enabled = true; 
            }
        }
    }
}

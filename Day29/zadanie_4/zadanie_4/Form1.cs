using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Bitmap sky, plane;
        private int dx; // Скорость самолета
        private Rectangle rct;
        private Timer timer1;
        private Random rnd;

        public Form1()
        {
            InitializeComponent();

            try
            {
                // Загружаем изображения
                sky = new Bitmap("zadanie_4/sky.bmp");
                plane = new Bitmap("zadanie_4/plane.bmp");

                // Устанавливаем фоновое изображение
                this.BackgroundImage = sky;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка загрузки изображений:\n{e}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Делаем фон самолета прозрачным
            plane.MakeTransparent();

            // Устанавливаем размеры формы
            this.ClientSize = new Size(sky.Width, sky.Height);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Исходное положение самолета
            rnd = new Random();
            rct = new Rectangle(-40, 20 + rnd.Next(20), plane.Width, plane.Height);

            // Скорость полета
            dx = 2;

            // Таймер для обновления кадра
            timer1 = new Timer();
            timer1.Interval = 20;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Движение самолета
            if (rct.X < this.ClientRectangle.Width)
                rct.X += dx;
            else
            {
                // Перезапуск самолета в случайном месте
                rct.X = -40;
                rct.Y = 20 + rnd.Next(this.ClientSize.Height - 40 - plane.Height);
                dx = 2 + rnd.Next(4); // Случайная скорость
            }

            Invalidate(); // Перерисовка формы
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Рисуем самолет
            g.DrawImage(plane, rct.X, rct.Y);
        }
    }
}

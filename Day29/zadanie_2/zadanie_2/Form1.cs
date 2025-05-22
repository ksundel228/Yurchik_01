using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie_2
{
    public partial class Form1 : Form
    {
        private Bitmap banner;
        private Rectangle rct;
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();

            try
            {
                banner = new Bitmap("banner.png"); // Загружаем баннер
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка загрузки файла баннера\n{e}", "Баннер");
                Close();
                return;
            }

            rct = new Rectangle(0, 0, banner.Width, banner.Height);

            // Создаем и настраиваем таймер
            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1; // Смещаем баннер влево

            if (Math.Abs(rct.X) > rct.Width) // Если баннер полностью ушел за левую границу
                rct.X += rct.Width; // Перемещаем его обратно

            Invalidate(); // Обновляем форму
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Отображаем баннер повторно, чтобы он плавно перемещался
            for (int i = 0; i <= (ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(banner, rct.X + i * rct.Width, rct.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Останавливаем движение при наведении курсора на баннер
            if (e.Y > rct.Y && e.Y < rct.Y + rct.Height)
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

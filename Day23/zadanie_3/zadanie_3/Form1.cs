using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 🔹 Фон формы (белый)
            g.Clear(Color.White);

            // 🔹 Рисуем арбуз (основной круг)
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            g.FillEllipse(greenBrush, 50, 50, 300, 200);

            // 🔹 Рисуем красную мякоть
            SolidBrush redBrush = new SolidBrush(Color.Red);
            g.FillEllipse(redBrush, 70, 70, 260, 160);

            // 🔹 Рисуем семечки арбуза
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillEllipse(blackBrush, 150, 100, 10, 15);
            g.FillEllipse(blackBrush, 200, 130, 10, 15);
            g.FillEllipse(blackBrush, 250, 110, 10, 15);
            g.FillEllipse(blackBrush, 180, 150, 10, 15);

            // 🔹 Добавляем контур
            Pen borderPen = new Pen(Color.DarkGreen, 4);
            g.DrawEllipse(borderPen, 50, 50, 300, 200);
        }
    }
}

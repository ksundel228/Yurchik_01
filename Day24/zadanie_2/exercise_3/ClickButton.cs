using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_3
{
    public class ClickButton : Button
    {
        private int mClicks = 0;

        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++; // Увеличиваем счетчик кликов
            base.OnClick(e); // Вызываем стандартное поведение кнопки
            this.Invalidate(); // Перерисовываем кнопку
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringSize = g.MeasureString(Clicks.ToString(), this.Font);

            g.DrawString(Clicks.ToString(), this.Font, SystemBrushes.ControlText,
                this.Width - stringSize.Width - 3, this.Height - stringSize.Height - 3);
        }
    }
}
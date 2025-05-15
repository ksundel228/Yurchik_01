using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Добавляем пространство имен для Timer

namespace zadanie_3
{
    public class CustomComponent : Component
    {
        private Timer timer; // Используем System.Windows.Forms.Timer
        private int counter = 0;

        public event EventHandler CounterUpdated;

        public CustomComponent()
        {
            timer = new Timer();
            timer.Interval = 1000; // Обновляем каждую секунду
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            CounterUpdated?.Invoke(this, EventArgs.Empty);
        }

        public int GetCounter()
        {
            return counter;
        }
    }
}


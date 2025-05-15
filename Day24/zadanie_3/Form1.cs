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

        private Label label;
        private CustomComponent customComponent;
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeCustomComponent()
        {
            // Создаём Label для отображения счётчика
            label = new Label
            {
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(label);

            // Создаём пользовательский компонент
            customComponent = new CustomComponent();
            customComponent.CounterUpdated += CustomComponent_CounterUpdated;
        }

        private void CustomComponent_CounterUpdated(object sender, EventArgs e)
        {
            label.Text = $"Таймер: {customComponent.GetCounter()} сек.";
        }
    }
}

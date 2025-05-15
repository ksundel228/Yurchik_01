using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateElement_Click(object sender, EventArgs e)
        {
            // Получаем данные из полей ввода
            string elementType = txtElementType.Text.Trim().ToUpper();
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            Control newControl = null;

            // Определяем тип создаваемого элемента
            switch (elementType)
            {
                case "К":
                    newControl = new Button() { Text = "Кнопка" };
                    break;
                case "П":
                    newControl = new TextBox() { Text = "Поле ввода" };
                    break;
                case "М":
                    newControl = new Label() { Text = "Метка", AutoSize = true };
                    break;
                default:
                    MessageBox.Show("Введите К, П или М!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Настроить свойства
            newControl.Location = new Point(x, y);
            newControl.BackColor = Color.LightGray;
            newControl.Font = new Font("Arial", 12, FontStyle.Bold);

            // Добавляем элемент на форму
            this.Controls.Add(newControl);

            // Удаление элемента при наведении курсора
            newControl.MouseEnter += (s, args) => this.Controls.Remove(newControl);
        }
    }
}

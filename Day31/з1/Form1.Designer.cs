using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAirlineStaff
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFirstName, lblLastName, lblPosition, lblSalary, lblHireDate;
        private System.Windows.Forms.TextBox txtFirstName, txtLastName, txtPosition, txtSalary, txtHireDate;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Служащие авиакомпании";
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Панель заголовка
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);

            // Заголовок
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "🛫 Управление персоналом авиакомпании";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(250, 15);
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.panelHeader.Controls.Add(this.lblTitle);

            // Кнопки
            this.btnLoad = CreateStyledButton("Загрузить данные", new System.Drawing.Point(20, 100));
            this.btnAdd = CreateStyledButton("Добавить", new System.Drawing.Point(20, 160));
            this.btnUpdate = CreateStyledButton("Обновить", new System.Drawing.Point(20, 220));
            this.btnDelete = CreateStyledButton("Удалить", new System.Drawing.Point(20, 280));

            // Таблица (отображение данных)
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView1.Location = new System.Drawing.Point(250, 100);
            this.dataGridView1.Size = new System.Drawing.Size(600, 400);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;

            // Поля для ввода данных сотрудников
            this.lblFirstName = CreateLabel("Имя:", new System.Drawing.Point(20, 350));
            this.txtFirstName = CreateTextBox(new System.Drawing.Point(120, 350));

            this.lblLastName = CreateLabel("Фамилия:", new System.Drawing.Point(20, 390));
            this.txtLastName = CreateTextBox(new System.Drawing.Point(120, 390));

            this.lblPosition = CreateLabel("Должность:", new System.Drawing.Point(20, 430));
            this.txtPosition = CreateTextBox(new System.Drawing.Point(120, 430));

            this.lblSalary = CreateLabel("Зарплата:", new System.Drawing.Point(20, 470));
            this.txtSalary = CreateTextBox(new System.Drawing.Point(120, 470));

            this.lblHireDate = CreateLabel("Дата найма:", new System.Drawing.Point(20, 510));
            this.txtHireDate = CreateTextBox(new System.Drawing.Point(120, 510));

            // Добавление элементов на форму
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.txtHireDate);
            this.ResumeLayout(false);
        }

        private Button CreateStyledButton(string text, System.Drawing.Point location)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular);
            btn.Size = new System.Drawing.Size(200, 40);
            btn.Location = location;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = System.Drawing.Color.SteelBlue;
            btn.ForeColor = System.Drawing.Color.White;
            return btn;
        }

        private Label CreateLabel(string text, System.Drawing.Point location)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular);
            lbl.ForeColor = System.Drawing.Color.Black;
            lbl.Location = location;
            lbl.Size = new System.Drawing.Size(100, 25);
            return lbl;
        }

        private TextBox CreateTextBox(System.Drawing.Point location)
        {
            TextBox txt = new TextBox();
            txt.Size = new System.Drawing.Size(150, 25);
            txt.Location = location;
            return txt;
        }
    }
}

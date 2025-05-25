using System.Drawing;
using System.Windows.Forms;

namespace WinFormsTravelAgency
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad, btnDelete, btnAdd, btnUpdate;
        private System.Windows.Forms.Label lblTitle, lblTourName, lblDestination, lblPrice, lblFullName, lblPhone, lblEmail;
        private System.Windows.Forms.TextBox txtTourName, txtDestination, txtPrice, txtFullName, txtPhone, txtEmail;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Управление турами";
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblTitle = CreateLabel("Туристическое агентство", new System.Drawing.Point(350, 20));

            int buttonStartX = 50;
            int buttonStartY = 80;
            int buttonSpacing = 60;

            this.btnLoad = CreateStyledButton("Загрузить туры", new System.Drawing.Point(buttonStartX, buttonStartY));
            this.btnDelete = CreateStyledButton("Удалить тур", new System.Drawing.Point(buttonStartX, buttonStartY + buttonSpacing));
            this.btnAdd = CreateStyledButton("Добавить туриста", new System.Drawing.Point(buttonStartX, buttonStartY + 2 * buttonSpacing));
            this.btnUpdate = CreateStyledButton("Изменить туриста", new System.Drawing.Point(buttonStartX, buttonStartY + 3 * buttonSpacing));

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView1.Location = new System.Drawing.Point(300, 80);
            this.dataGridView1.Size = new System.Drawing.Size(650, 350);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;

            int inputStartX = 50;
            int inputStartY = 420;
            int inputSpacing = 50;

            this.lblTourName = CreateLabel("Название тура:", new System.Drawing.Point(inputStartX, inputStartY));
            this.txtTourName = CreateTextBox(new System.Drawing.Point(inputStartX + 140, inputStartY));

            this.lblDestination = CreateLabel("Место:", new System.Drawing.Point(inputStartX, inputStartY + inputSpacing));
            this.txtDestination = CreateTextBox(new System.Drawing.Point(inputStartX + 140, inputStartY + inputSpacing));

            this.lblPrice = CreateLabel("Цена:", new System.Drawing.Point(inputStartX, inputStartY + 2 * inputSpacing));
            this.txtPrice = CreateTextBox(new System.Drawing.Point(inputStartX + 140, inputStartY + 2 * inputSpacing));

            this.lblFullName = CreateLabel("ФИО:", new System.Drawing.Point(inputStartX + 400, inputStartY));
            this.txtFullName = CreateTextBox(new System.Drawing.Point(inputStartX + 540, inputStartY));

            this.lblPhone = CreateLabel("Телефон:", new System.Drawing.Point(inputStartX + 400, inputStartY + inputSpacing));
            this.txtPhone = CreateTextBox(new System.Drawing.Point(inputStartX + 540, inputStartY + inputSpacing));

            this.lblEmail = CreateLabel("Email:", new System.Drawing.Point(inputStartX + 400, inputStartY + 2 * inputSpacing));
            this.txtEmail = CreateTextBox(new System.Drawing.Point(inputStartX + 540, inputStartY + 2 * inputSpacing));

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTourName);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.ResumeLayout(false);
        }

        private Button CreateStyledButton(string text, System.Drawing.Point location)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular);
            btn.Size = new System.Drawing.Size(220, 45);
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
            lbl.Size = new System.Drawing.Size(120, 25);
            return lbl;
        }

        private TextBox CreateTextBox(System.Drawing.Point location)
        {
            TextBox txt = new TextBox();
            txt.Size = new System.Drawing.Size(180, 25);
            txt.Location = location;
            return txt;
        }
    }
}

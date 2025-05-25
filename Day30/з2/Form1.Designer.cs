namespace WinFormsTurFirm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnShowTours;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Button btnAddTourist;
        private System.Windows.Forms.Button btnUpdateTourist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;

        /// <summary>
        /// Освобождение ресурсов компонентов
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализация элементов формы
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowTours = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnAddTourist = new System.Windows.Forms.Button();
            this.btnUpdateTourist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowTours
            // 
            this.btnShowTours.Location = new System.Drawing.Point(20, 20);
            this.btnShowTours.Name = "btnShowTours";
            this.btnShowTours.Size = new System.Drawing.Size(200, 40);
            this.btnShowTours.TabIndex = 0;
            this.btnShowTours.Text = "Показать все туры";
            this.btnShowTours.Click += new System.EventHandler(this.btnShowTours_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Location = new System.Drawing.Point(20, 70);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteTour.TabIndex = 1;
            this.btnDeleteTour.Text = "Удалить тур";
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // btnAddTourist
            // 
            this.btnAddTourist.Location = new System.Drawing.Point(20, 120);
            this.btnAddTourist.Name = "btnAddTourist";
            this.btnAddTourist.Size = new System.Drawing.Size(200, 40);
            this.btnAddTourist.TabIndex = 2;
            this.btnAddTourist.Text = "Добавить туриста";
            this.btnAddTourist.Click += new System.EventHandler(this.btnAddTourist_Click);
            // 
            // btnUpdateTourist
            // 
            this.btnUpdateTourist.Location = new System.Drawing.Point(20, 170);
            this.btnUpdateTourist.Name = "btnUpdateTourist";
            this.btnUpdateTourist.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateTourist.TabIndex = 3;
            this.btnUpdateTourist.Text = "Изменить туриста";
            this.btnUpdateTourist.Click += new System.EventHandler(this.btnUpdateTourist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(250, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(500, 250);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 350);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 380);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 410);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 320);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 22);
            this.txtID.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 350);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 25);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "ФИО:";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 380);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 25);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Телефон:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 410);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 25);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(20, 320);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 25);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnShowTours);
            this.Controls.Add(this.btnDeleteTour);
            this.Controls.Add(this.btnAddTourist);
            this.Controls.Add(this.btnUpdateTourist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Управление турами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

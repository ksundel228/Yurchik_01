using System.Windows.Forms;

namespace RocketLaunchApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код формы

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(300, 400);
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Запуск ракеты";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
        }

        #endregion
    }
}

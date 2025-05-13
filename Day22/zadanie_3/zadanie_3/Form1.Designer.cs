namespace zadanie_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtXk = new System.Windows.Forms.TextBox();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(101, 36);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(100, 22);
            this.txtX0.TabIndex = 0;
            this.txtX0.Text = "Введите x0:";
            // 
            // txtXk
            // 
            this.txtXk.Location = new System.Drawing.Point(101, 79);
            this.txtXk.Name = "txtXk";
            this.txtXk.Size = new System.Drawing.Size(100, 22);
            this.txtXk.TabIndex = 1;
            this.txtXk.Text = "Введите xk:";
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(101, 123);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(100, 22);
            this.txtDx.TabIndex = 2;
            this.txtDx.Text = "Введите шаг dx:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(101, 166);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "Введите b:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(101, 218);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 264);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(313, 382);
            this.txtResults.TabIndex = 5;
            this.txtResults.Text = "Таблица значений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(337, 658);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.txtXk);
            this.Controls.Add(this.txtX0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtXk;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResults;
    }
}


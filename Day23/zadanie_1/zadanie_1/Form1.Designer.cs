namespace zadanie_1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheckPalindrome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "А роза упала на лапу Азора",
            "Шалаш",
            "Я иду с мечем судия",
            "Сегодня прекрасная погода",
            "Код пишется шаг за шагом"});
            this.listBox1.Location = new System.Drawing.Point(81, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 148);
            this.listBox1.TabIndex = 0;
            // 
            // btnCheckPalindrome
            // 
            this.btnCheckPalindrome.Location = new System.Drawing.Point(81, 279);
            this.btnCheckPalindrome.Name = "btnCheckPalindrome";
            this.btnCheckPalindrome.Size = new System.Drawing.Size(194, 32);
            this.btnCheckPalindrome.TabIndex = 1;
            this.btnCheckPalindrome.Text = "Проверить палиндром";
            this.btnCheckPalindrome.UseVisualStyleBackColor = true;
            this.btnCheckPalindrome.Click += new System.EventHandler(this.btnCheckPalindrome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckPalindrome);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCheckPalindrome;
        private System.Windows.Forms.Label label1;
    }
}


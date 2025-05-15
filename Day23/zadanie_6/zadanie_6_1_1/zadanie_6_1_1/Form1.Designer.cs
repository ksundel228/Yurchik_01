namespace zadanie_6_1_1
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
            this.btnBorderStyle = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnOpacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorderStyle
            // 
            this.btnBorderStyle.Location = new System.Drawing.Point(184, 117);
            this.btnBorderStyle.Name = "btnBorderStyle";
            this.btnBorderStyle.Size = new System.Drawing.Size(144, 23);
            this.btnBorderStyle.TabIndex = 0;
            this.btnBorderStyle.Text = "Border Style";
            this.btnBorderStyle.UseVisualStyleBackColor = true;
            this.btnBorderStyle.Click += new System.EventHandler(this.btnBorderStyle_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(184, 169);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(144, 23);
            this.btnResize.TabIndex = 1;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnOpacity
            // 
            this.btnOpacity.Location = new System.Drawing.Point(184, 222);
            this.btnOpacity.Name = "btnOpacity";
            this.btnOpacity.Size = new System.Drawing.Size(144, 23);
            this.btnOpacity.TabIndex = 2;
            this.btnOpacity.Text = "Opacity";
            this.btnOpacity.UseVisualStyleBackColor = true;
            this.btnOpacity.Click += new System.EventHandler(this.btnOpacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpacity);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnBorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorderStyle;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnOpacity;
    }
}


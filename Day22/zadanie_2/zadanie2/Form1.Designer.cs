namespace zadanie2
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.radioSh = new System.Windows.Forms.RadioButton();
            this.radioX2 = new System.Windows.Forms.RadioButton();
            this.radioExp = new System.Windows.Forms.RadioButton();
            this.grpFunctions = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(33, 46);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(75, 16);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Введите х:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(33, 87);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(77, 16);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Введите у:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(33, 129);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(75, 16);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "Введите z:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(125, 43);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(125, 84);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 4;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(125, 126);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 22);
            this.txtZ.TabIndex = 5;
            // 
            // radioSh
            // 
            this.radioSh.AutoSize = true;
            this.radioSh.Location = new System.Drawing.Point(6, 21);
            this.radioSh.Name = "radioSh";
            this.radioSh.Size = new System.Drawing.Size(56, 20);
            this.radioSh.TabIndex = 6;
            this.radioSh.TabStop = true;
            this.radioSh.Text = "sh(x)";
            this.radioSh.UseVisualStyleBackColor = true;
            // 
            // radioX2
            // 
            this.radioX2.AutoSize = true;
            this.radioX2.Location = new System.Drawing.Point(6, 47);
            this.radioX2.Name = "radioX2";
            this.radioX2.Size = new System.Drawing.Size(38, 20);
            this.radioX2.TabIndex = 7;
            this.radioX2.TabStop = true;
            this.radioX2.Text = "x²";
            this.radioX2.UseVisualStyleBackColor = true;
            // 
            // radioExp
            // 
            this.radioExp.AutoSize = true;
            this.radioExp.Location = new System.Drawing.Point(6, 74);
            this.radioExp.Name = "radioExp";
            this.radioExp.Size = new System.Drawing.Size(49, 20);
            this.radioExp.TabIndex = 8;
            this.radioExp.TabStop = true;
            this.radioExp.Text = "e^x";
            this.radioExp.UseVisualStyleBackColor = true;
            // 
            // grpFunctions
            // 
            this.grpFunctions.Controls.Add(this.radioSh);
            this.grpFunctions.Controls.Add(this.radioExp);
            this.grpFunctions.Controls.Add(this.radioX2);
            this.grpFunctions.Location = new System.Drawing.Point(36, 182);
            this.grpFunctions.Name = "grpFunctions";
            this.grpFunctions.Size = new System.Drawing.Size(189, 100);
            this.grpFunctions.TabIndex = 9;
            this.grpFunctions.TabStop = false;
            this.grpFunctions.Text = "Выберите функцию";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 298);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(189, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(39, 346);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(418, 477);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpFunctions);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "zadanie2";
            this.grpFunctions.ResumeLayout(false);
            this.grpFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.RadioButton radioSh;
        private System.Windows.Forms.RadioButton radioX2;
        private System.Windows.Forms.RadioButton radioExp;
        private System.Windows.Forms.GroupBox grpFunctions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}


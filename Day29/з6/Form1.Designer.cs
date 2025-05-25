namespace ClockApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Часы";
            this.BackColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load); 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint); 
            this.ResumeLayout(false);
        }

        #endregion
    }
}

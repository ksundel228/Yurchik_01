using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication_упр._4_
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            spData.Text = DateTime.Today.ToLongDateString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CascadeWindows_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void TileWindows_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

    }
}

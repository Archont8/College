using System;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void toggleForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleForegroundToolStripMenuItem.Checked)
            {
                toggleForegroundToolStripMenuItem.Checked = false;
                richTextBox1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                toggleForegroundToolStripMenuItem.Checked = true;
                richTextBox1.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIbase
{
    public partial class frmContainer : Form
    {
        private int nextFormNumber = 2;
        public frmContainer()
        {
            InitializeComponent();
            frmChild child = new frmChild(this, "Редактор 1");
            child.Show();
        }

        private void MenuItemNewWindow_Click(object sender, EventArgs e)
        {
            frmChild newChild = new frmChild(this, "Редактор" + nextFormNumber++);
            newChild.Show();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            frmChild frm = (frmChild)this.ActiveMdiChild;
            if (frm != null) 
                frm.Close();
            }
    }
}

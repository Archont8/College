using System.Windows.Forms;
using System;

namespace Romb
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            romb.Show(this);
        }
    }
}

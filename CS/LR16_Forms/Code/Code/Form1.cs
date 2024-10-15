using System;
using System.Windows.Forms;

namespace Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            
            if (node == null)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = textBox1.Text;
                newNode.ImageIndex = 0;
                treeView1.Nodes.Add(newNode);
            }

            else
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = textBox1.Text;
                newNode.ImageIndex = 0;
                node.Nodes.Add(newNode);
            }
        }
    }
}

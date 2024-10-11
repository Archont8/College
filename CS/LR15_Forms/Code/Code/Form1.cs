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
            if (comboBox1.Text.Length != 0)
            {
                checkedListBox1.Items.Add(comboBox1.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count > 0)
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Sorted = true;
        }
    }
}

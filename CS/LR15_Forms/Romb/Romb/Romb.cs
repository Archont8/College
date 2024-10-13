using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Romb
{
    public partial class Romb : Form
    {
        public Romb()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Green;
            button1.Click += button1_Click;
            this.Controls.Add(button1);
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                    new Point(0, this.Height/2),
                    new Point(this.Width/2, 0),
                    new Point(this.Width, this.Height/2),
                    new Point(this.Width/2, this.Height)
                });
                Region = new Region(myPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
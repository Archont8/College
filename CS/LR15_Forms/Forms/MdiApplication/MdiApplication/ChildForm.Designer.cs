using System.Windows.Forms;
namespace MdiApplication
{
    partial class ChildForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new RichTextBox();
            this.menuStrip1 = new MenuStrip();
            this.formatToolStripMenuItem = new ToolStripMenuItem();
            this.toggleForegroundToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "ChildTextBox";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "ChildWindowMenu";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.toggleForegroundToolStripMenuItem});
            this.formatToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.formatToolStripMenuItem.MergeIndex = 1;
            this.formatToolStripMenuItem.Name = "FormatMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // toggleForegroundToolStripMenuItem
            // 
            this.toggleForegroundToolStripMenuItem.Name = "ToggleMenuItem";
            this.toggleForegroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toggleForegroundToolStripMenuItem.Text = "Toggle foreground";
            this.toggleForegroundToolStripMenuItem.Click += new System.EventHandler(this.toggleForegroundToolStripMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem toggleForegroundToolStripMenuItem;
    }
}
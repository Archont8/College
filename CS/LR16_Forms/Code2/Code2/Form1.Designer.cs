using System.Drawing;
using System.Windows.Forms;
namespace Code2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(347, 64);
            this.vScrollBar1.Maximum = 60;
            this.vScrollBar1.Minimum = 20;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(82, 329);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 32;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фаренгейт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(222, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "32";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(495, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цельсий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(498, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}


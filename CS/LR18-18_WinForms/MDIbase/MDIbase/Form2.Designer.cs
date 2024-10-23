namespace MDIbase
{
    partial class frmChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemBold = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfText
            // 
            this.rtfText.ContextMenuStrip = this.contextMenuStrip1;
            this.rtfText.Location = new System.Drawing.Point(0, 27);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(800, 423);
            this.rtfText.TabIndex = 0;
            this.rtfText.Text = "";
            this.rtfText.TextChanged += new System.EventHandler(this.rtfText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemBold,
            this.MenuItemItalic,
            this.MenuItemUnderline});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            // 
            // MenuItemBold
            // 
            this.MenuItemBold.Name = "MenuItemBold";
            this.MenuItemBold.Size = new System.Drawing.Size(156, 22);
            this.MenuItemBold.Text = "Полужирный";
            this.MenuItemBold.Click += new System.EventHandler(this.MenuItemBold_Click);
            // 
            // MenuItemItalic
            // 
            this.MenuItemItalic.Name = "MenuItemItalic";
            this.MenuItemItalic.Size = new System.Drawing.Size(156, 22);
            this.MenuItemItalic.Text = "Курсив";
            this.MenuItemItalic.Click += new System.EventHandler(this.MenuItemItalic_Click);
            // 
            // MenuItemUnderline
            // 
            this.MenuItemUnderline.Name = "MenuItemUnderline";
            this.MenuItemUnderline.Size = new System.Drawing.Size(156, 22);
            this.MenuItemUnderline.Text = "Подчеркнутый";
            this.MenuItemUnderline.Click += new System.EventHandler(this.MenuItemUnderline_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.MenuItemOpen,
            this.MenuItemSave});
            this.MenuItemFile.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "Файл";
            this.MenuItemFile.Click += new System.EventHandler(this.MenuItemFile_Click);
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemNew.MergeIndex = 1;
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.Size = new System.Drawing.Size(180, 22);
            this.MenuItemNew.Text = "Создать";
            this.MenuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemOpen.MergeIndex = 2;
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuItemOpen.Text = "Открыть";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemSave.MergeIndex = 3;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSave.Text = "Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtfText);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChild";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBold;
        private System.Windows.Forms.ToolStripMenuItem MenuItemItalic;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUnderline;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
    }
}
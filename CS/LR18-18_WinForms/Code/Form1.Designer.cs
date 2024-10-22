using System.Windows.Forms;
namespace Code
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

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уведомитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщение1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщение2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщение3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильБегункаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пустоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуслеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снизусправаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сОбеихСторонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.пустоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуслеваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.снизусправаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сОбеихСторонToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ориентацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ориентацияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.веToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавтToolStripMenuItem,
            this.стильБегункаToolStripMenuItem,
            this.ориентацияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавтToolStripMenuItem
            // 
            this.добавтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.переместитьToolStripMenuItem,
            this.уведомитьToolStripMenuItem});
            this.добавтToolStripMenuItem.Name = "добавтToolStripMenuItem";
            this.добавтToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.добавтToolStripMenuItem.Text = "Команда меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            this.переместитьToolStripMenuItem.Click += new System.EventHandler(this.переместитьToolStripMenuItem_Click);
            // 
            // уведомитьToolStripMenuItem
            // 
            this.уведомитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сообщение1ToolStripMenuItem,
            this.сообщение2ToolStripMenuItem,
            this.сообщение3ToolStripMenuItem});
            this.уведомитьToolStripMenuItem.Name = "уведомитьToolStripMenuItem";
            this.уведомитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.уведомитьToolStripMenuItem.Text = "Уведомить";
            this.уведомитьToolStripMenuItem.Click += new System.EventHandler(this.уведомитьToolStripMenuItem_Click);
            // 
            // сообщение1ToolStripMenuItem
            // 
            this.сообщение1ToolStripMenuItem.Name = "сообщение1ToolStripMenuItem";
            this.сообщение1ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сообщение1ToolStripMenuItem.Text = "Сообщение 1";
            this.сообщение1ToolStripMenuItem.Click += new System.EventHandler(this.уведомитьToolStripMenuItem_Click);
            // 
            // сообщение2ToolStripMenuItem
            // 
            this.сообщение2ToolStripMenuItem.Name = "сообщение2ToolStripMenuItem";
            this.сообщение2ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сообщение2ToolStripMenuItem.Text = "Сообщение 2";
            this.сообщение2ToolStripMenuItem.Click += new System.EventHandler(this.уведомитьToolStripMenuItem_Click);
            // 
            // сообщение3ToolStripMenuItem
            // 
            this.сообщение3ToolStripMenuItem.Name = "сообщение3ToolStripMenuItem";
            this.сообщение3ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сообщение3ToolStripMenuItem.Text = "Сообщение 3";
            this.сообщение3ToolStripMenuItem.Click += new System.EventHandler(this.уведомитьToolStripMenuItem_Click);
            // 
            // стильБегункаToolStripMenuItem
            // 
            this.стильБегункаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустоToolStripMenuItem,
            this.сверхуслеваToolStripMenuItem,
            this.снизусправаToolStripMenuItem,
            this.сОбеихСторонToolStripMenuItem});
            this.стильБегункаToolStripMenuItem.Name = "стильБегункаToolStripMenuItem";
            this.стильБегункаToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.стильБегункаToolStripMenuItem.Text = "Стиль бегунка";
            // 
            // пустоToolStripMenuItem
            // 
            this.пустоToolStripMenuItem.Name = "пустоToolStripMenuItem";
            this.пустоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пустоToolStripMenuItem.Text = "Пусто";
            this.пустоToolStripMenuItem.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // сверхуслеваToolStripMenuItem
            // 
            this.сверхуслеваToolStripMenuItem.Name = "сверхуслеваToolStripMenuItem";
            this.сверхуслеваToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сверхуслеваToolStripMenuItem.Text = "Сверху-слева";
            this.сверхуслеваToolStripMenuItem.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // снизусправаToolStripMenuItem
            // 
            this.снизусправаToolStripMenuItem.Name = "снизусправаToolStripMenuItem";
            this.снизусправаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.снизусправаToolStripMenuItem.Text = "Снизу-справа";
            this.снизусправаToolStripMenuItem.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // сОбеихСторонToolStripMenuItem
            // 
            this.сОбеихСторонToolStripMenuItem.Name = "сОбеихСторонToolStripMenuItem";
            this.сОбеихСторонToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сОбеихСторонToolStripMenuItem.Text = "С обеих сторон";
            this.сОбеихСторонToolStripMenuItem.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.trackBar1.Location = new System.Drawing.Point(279, 71);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(255, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem1,
            this.переместитьToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip5";
            this.contextMenuStrip.Size = new System.Drawing.Size(147, 70);
            this.contextMenuStrip.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // переместитьToolStripMenuItem1
            // 
            this.переместитьToolStripMenuItem1.Name = "переместитьToolStripMenuItem1";
            this.переместитьToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.переместитьToolStripMenuItem1.Text = "Переместить";
            this.переместитьToolStripMenuItem1.Click += new System.EventHandler(this.переместитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустоToolStripMenuItem1,
            this.сверхуслеваToolStripMenuItem1,
            this.снизусправаToolStripMenuItem1,
            this.сОбеихСторонToolStripMenuItem1,
            this.ориентацияToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 114);
            // 
            // пустоToolStripMenuItem1
            // 
            this.пустоToolStripMenuItem1.Name = "пустоToolStripMenuItem1";
            this.пустоToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.пустоToolStripMenuItem1.Text = "Пусто";
            this.пустоToolStripMenuItem1.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // сверхуслеваToolStripMenuItem1
            // 
            this.сверхуслеваToolStripMenuItem1.Name = "сверхуслеваToolStripMenuItem1";
            this.сверхуслеваToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.сверхуслеваToolStripMenuItem1.Text = "Сверху-слева";
            this.сверхуслеваToolStripMenuItem1.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // снизусправаToolStripMenuItem1
            // 
            this.снизусправаToolStripMenuItem1.Checked = true;
            this.снизусправаToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.снизусправаToolStripMenuItem1.Name = "снизусправаToolStripMenuItem1";
            this.снизусправаToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.снизусправаToolStripMenuItem1.Text = "Снизу-справа";
            this.снизусправаToolStripMenuItem1.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // сОбеихСторонToolStripMenuItem1
            // 
            this.сОбеихСторонToolStripMenuItem1.Name = "сОбеихСторонToolStripMenuItem1";
            this.сОбеихСторонToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.сОбеихСторонToolStripMenuItem1.Text = "С обеих сторон";
            this.сОбеихСторонToolStripMenuItem1.Click += new System.EventHandler(this.пустоToolStripMenuItem_Click);
            // 
            // ориентацияToolStripMenuItem
            // 
            this.ориентацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.горизонтальнаяToolStripMenuItem,
            this.вертикальнаяToolStripMenuItem});
            this.ориентацияToolStripMenuItem.Name = "ориентацияToolStripMenuItem";
            this.ориентацияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.ориентацияToolStripMenuItem.Text = "Ориентация";
            this.ориентацияToolStripMenuItem.Click += new System.EventHandler(this.ориентацияToolStripMenuItem_Click);
            // 
            // горизонтальнаяToolStripMenuItem
            // 
            this.горизонтальнаяToolStripMenuItem.Name = "горизонтальнаяToolStripMenuItem";
            this.горизонтальнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.горизонтальнаяToolStripMenuItem.Text = "Горизонтальная";
            this.горизонтальнаяToolStripMenuItem.Click += new System.EventHandler(this.ориентацияToolStripMenuItem_Click);
            // 
            // вертикальнаяToolStripMenuItem
            // 
            this.вертикальнаяToolStripMenuItem.Name = "вертикальнаяToolStripMenuItem";
            this.вертикальнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вертикальнаяToolStripMenuItem.Text = "Вертикальная";
            this.вертикальнаяToolStripMenuItem.Click += new System.EventHandler(this.ориентацияToolStripMenuItem_Click);
            // 
            // ориентацияToolStripMenuItem1
            // 
            this.ориентацияToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.веToolStripMenuItem,
            this.вертикальнаяToolStripMenuItem1});
            this.ориентацияToolStripMenuItem1.Name = "ориентацияToolStripMenuItem1";
            this.ориентацияToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.ориентацияToolStripMenuItem1.Text = "Ориентация";
            // 
            // веToolStripMenuItem
            // 
            this.веToolStripMenuItem.Name = "веToolStripMenuItem";
            this.веToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.веToolStripMenuItem.Text = "Горизонтальная";
            this.веToolStripMenuItem.Click += new System.EventHandler(this.ориентацияToolStripMenuItem_Click);
            // 
            // вертикальнаяToolStripMenuItem1
            // 
            this.вертикальнаяToolStripMenuItem1.Name = "вертикальнаяToolStripMenuItem1";
            this.вертикальнаяToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.вертикальнаяToolStripMenuItem1.Text = "Вертикальная";
            this.вертикальнаяToolStripMenuItem1.Click += new System.EventHandler(this.ориентацияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавтToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem переместитьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem уведомитьToolStripMenuItem;
        private ToolStripMenuItem сообщение1ToolStripMenuItem;
        private ToolStripMenuItem сообщение2ToolStripMenuItem;
        private ToolStripMenuItem сообщение3ToolStripMenuItem;
        private ToolStripMenuItem стильБегункаToolStripMenuItem;
        private ToolStripMenuItem пустоToolStripMenuItem;
        private ToolStripMenuItem сверхуслеваToolStripMenuItem;
        private ToolStripMenuItem снизусправаToolStripMenuItem;
        private ToolStripMenuItem сОбеихСторонToolStripMenuItem;
        private TrackBar trackBar1;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem добавитьToolStripMenuItem2;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private ToolStripMenuItem переместитьToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem пустоToolStripMenuItem1;
        private ToolStripMenuItem сверхуслеваToolStripMenuItem1;
        private ToolStripMenuItem снизусправаToolStripMenuItem1;
        private ToolStripMenuItem сОбеихСторонToolStripMenuItem1;
        private ToolStripMenuItem ориентацияToolStripMenuItem;
        private ToolStripMenuItem горизонтальнаяToolStripMenuItem;
        private ToolStripMenuItem вертикальнаяToolStripMenuItem;
        private ToolStripMenuItem ориентацияToolStripMenuItem1;
        private ToolStripMenuItem веToolStripMenuItem;
        private ToolStripMenuItem вертикальнаяToolStripMenuItem1;
    }
}


namespace WinFormsApp1
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
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkedListBox1 = new CheckedListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(12, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "ФИО";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(12, 304);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Категория годности";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DimGray;
            textBox3.Location = new Point(12, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "Род войск";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.DimGray;
            textBox4.Location = new Point(12, 362);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Адрес";
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.DimGray;
            textBox5.Location = new Point(12, 391);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 23);
            textBox5.TabIndex = 5;
            textBox5.Text = "Номер паспорта";
            // 
            // textBox6
            // 
            textBox6.ForeColor = Color.DimGray;
            textBox6.Location = new Point(12, 420);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(159, 23);
            textBox6.TabIndex = 6;
            textBox6.Text = "Серия паспорта";
            // 
            // button1
            // 
            button1.Location = new Point(499, 261);
            button1.Name = "button1";
            button1.Size = new Size(289, 23);
            button1.TabIndex = 7;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(499, 435);
            button2.Name = "button2";
            button2.Size = new Size(289, 23);
            button2.TabIndex = 8;
            button2.Text = "Очистить список";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(499, 464);
            button3.Name = "button3";
            button3.Size = new Size(285, 23);
            button3.TabIndex = 14;
            button3.Text = "Загрузить в БД";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 17);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(777, 238);
            checkedListBox1.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(500, 290);
            button4.Name = "button4";
            button4.Size = new Size(289, 23);
            button4.TabIndex = 17;
            button4.Text = "Удалить выбранного";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(500, 493);
            button5.Name = "button5";
            button5.Size = new Size(285, 23);
            button5.TabIndex = 18;
            button5.Text = "Записать в файл";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 513);
            button6.Name = "button6";
            button6.Size = new Size(135, 23);
            button6.TabIndex = 19;
            button6.Text = "ВЫХОД";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(500, 319);
            button7.Name = "button7";
            button7.Size = new Size(289, 23);
            button7.TabIndex = 20;
            button7.Text = "Отправить на СВО";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(500, 348);
            button8.Name = "button8";
            button8.Size = new Size(289, 23);
            button8.TabIndex = 21;
            button8.Text = "Освободить от призыва";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(500, 377);
            button9.Name = "button9";
            button9.Size = new Size(289, 23);
            button9.TabIndex = 22;
            button9.Text = "Отправить в учебный центр";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(500, 406);
            button10.Name = "button10";
            button10.Size = new Size(289, 23);
            button10.TabIndex = 23;
            button10.Text = "Отправить в военный ВУЗ";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 548);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(checkedListBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Информационная система управления деятельностью военкомата";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}

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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление");
        }

        private void переместитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перемещение");
        }

        private void уведомитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string message = item.Text;
            MessageBox.Show(message);
        }

        private void пустоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;
            switch (text)
            {
                case "Пусто":
                    trackBar1.TickStyle = TickStyle.None;
                    break;
                case "Сверху-слева":
                    trackBar1.TickStyle = TickStyle.TopLeft;
                    break;
                case "Снизу-справа":
                    trackBar1.TickStyle = TickStyle.BottomRight;
                    break;
                case "С обеих сторон":
                    trackBar1.TickStyle = TickStyle.Both;
                    break;
            }
            // если текст меню совпадает с переданным параметром, 
            // то помечаем пункт меню 
            if (item.Text == text)
                item.Checked = true;
            // если текст меню не совпадает с переданным параметром, 
            // то снимаем пометку с пункта меню 
            else
                item.Checked = false;
            // проходим по всем подпунктам, изменяющим стиль бегунка и
            // расположенных в контекстном меню программы 
            foreach (ToolStripMenuItem item1 in contextMenuStrip1.Items)
            {
                // если текст меню совпадает с переданным параметром, 
                // то помечаем пункт меню 
                if (item.Text == text)
                    item.Checked = true;
                // если текст меню не совпадает с переданным параметром, 
                // то снимаем пометку с пункта меню 
                else
                    item.Checked = false;
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение Данила Сафронова");
        }

        private void ориентацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;
            switch (text)
            {
                case "Горизонтальная": 
                    trackBar1.Orientation = Orientation.Horizontal; break;
                case "Вертикальная":
                    trackBar1.Orientation = Orientation.Vertical; break;
            }
        }
    }
}

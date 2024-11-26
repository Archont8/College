using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connect = "Data Source = soldiers.db";
        string pathToFile = "Soldiers";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text;
            try
            {
                if (textBox1.Text.Length == 0 | textBox2.Text.Length == 0 | textBox3.Text.Length == 0 | textBox4.Text.Length == 0 | textBox5.Text.Length == 0 | textBox6.Text.Length == 0)
                {
                    throw new Exception("Одно из полей пустое!");
                }
                foreach (var x in textBox1.Text)
                {
                    if (Char.IsDigit(x))
                    {
                        throw new Exception("Поле 'ФИО' не может содержать цифры");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("Поле 'ФИО' не может содержать символы");
                    }
                }
                if (textBox2.Text.Length > 1)
                {
                    throw new Exception("В поле 'категория годности' не может быть более одной буквы");
                }
                foreach (var x in textBox2.Text)
                {
                    if (Char.IsDigit(x))
                    {
                        throw new Exception("В поле 'категория годности' не может быть цифр");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("В поле 'категория годности' не может быть символов");
                    }
                }
                foreach (var x in textBox3.Text)
                {
                    if (Char.IsDigit(x))
                    {
                        throw new Exception("В поле 'род войск' не может быть цифр");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("В поле 'род войск' не может быть символов");
                    }
                }
                foreach (var x in textBox5.Text)
                {
                    if (Char.IsLetter(x))
                    {
                        throw new Exception("В поле 'номер паспорта' не может быть букв");
                    }
                    if (Char.IsControl(x))
                    {
                        throw new Exception("В поле 'номер паспорта' не может быть символов");
                    }
                }
                foreach (var x in textBox6.Text)
                {
                    if (Char.IsLetter(x))
                    {
                        throw new Exception("В поле 'серия паспорта' не может быть букв");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("В поле 'серия паспорта' не может быть символов");
                    }
                }
                checkedListBox1.Items.Add(text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBox1.Items.Count > 0)
                {
                    checkedListBox1.Items.Clear();
                }
                else
                {
                    throw new Exception("Список пуст, очищать нечего");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task task = button3_ClickTask();
            task.Wait();
            MessageBox.Show("Загрузка в БД завершена");
        }
        async private Task button3_ClickTask()
        {
            Soldier soldier = new Soldier(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

            using (var connection = new SQLiteConnection(connect))
            {
                await connection.OpenAsync();
                string createTable = @"
                CREATE TABLE IF NOT EXISTS Soldiers(
                id INTEGER NOT NULL PRIMARY KEY, 
                FIO nvarchar (50),
                ValidityCategory nvarchar (50),
                MilitaryBranch nvarchar (50),
                Address nvarchar (50),
                PassportNumber nvarchar (50),
                PassportSeries nvarchar (50)
                )";
                string sql = @"
                INSERT INTO Soldiers(FIO, ValidityCategory, MilitaryBranch, Address, PassportNumber, PassportSeries)
                SELECT @FIO, @ValidityCategory, @MilitaryBranch, @Address, @PassportNumber, @PassportSeries
                ";
                using (var command = new SQLiteCommand(createTable, connection)) 
                { 
                    await command.ExecuteNonQueryAsync();
                }

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FIO", soldier.FIO);
                    command.Parameters.AddWithValue("@ValidityCategory", soldier.ValidityCategory);
                    command.Parameters.AddWithValue("@MilitaryBranch", soldier.MilitaryBranch);
                    command.Parameters.AddWithValue("@Address", soldier.Address);
                    command.Parameters.AddWithValue("@PassportNumber", soldier.PassportNumber);
                    command.Parameters.AddWithValue("@PassportSeries", soldier.@PassportSeries);
                    await command.ExecuteNonQueryAsync();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem!);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var x in checkedListBox1.Items)
            {
                File.AppendAllText(pathToFile, $"{x.ToString()}\n");
            }

            MessageBox.Show("Запись в файл завершена!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText(pathToFile, "");
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem!);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem!);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem!);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem!);
        }
    }
}

using System.Data.SQLite;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connect = "Data Source = C:\\Users\\312-12\\Documents\\GitHub\\College\\CourseWork\\CourseProject\\WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\soldiers.db";
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
                    throw new Exception("One of the fields is empty!");
                }
                foreach (var x in textBox1.Text)
                {
                    if (Char.IsDigit(x))
                    {
                        throw new Exception("Field FIO can't contain digits");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("Field FIO can't contain symbols");
                    }
                }
                if (textBox2.Text.Length > 1)
                {
                    throw new Exception("Field validity category can't contain more than 1 symbol");
                }
                foreach (var x in textBox2.Text)
                {
                    if (Char.IsDigit(x))
                    {
                        throw new Exception("Field validity category can't contain digits");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("Field validity category can't contain symbols");
                    }
                }
                foreach (var x in textBox3.Text)
                {
                    if (Char.IsDigit(x))
                    {
                        throw new Exception("Field military branch can't contain digits");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("Field military branch can't contain controls");
                    }
                }
                foreach (var x in textBox5.Text)
                {
                    if (Char.IsLetter(x))
                    {
                        throw new Exception("Passport number can't contain letters");
                    }
                    if (Char.IsControl(x))
                    {
                        throw new Exception("Passport number can't contain symbols");
                    }
                }
                foreach (var x in textBox6.Text)
                {
                    if (Char.IsLetter(x))
                    {
                        throw new Exception("Passport series can't contain letters");
                    }
                    else if (Char.IsControl(x))
                    {
                        throw new Exception("Passport series can't contain symbols");
                    }
                }
                checkedListBox1.Items.Add(text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
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
                    throw new Exception("The list is empty, there is nothing to clear");
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
            /*using (var con = new SQLiteConnection(connect))
            {
                using (var command = new SQLiteCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@FIO", soldier.FIO);
                    command.Parameters.AddWithValue("@ValidityCategory", soldier.ValidityCategory);
                    command.Parameters.AddWithValue("@MilitaryBranch", soldier.MilitaryBranch);
                    command.Parameters.AddWithValue("@Address", soldier.Address);
                    command.Parameters.AddWithValue("@PassportNumber", soldier.PassportNumber);
                    command.Parameters.AddWithValue("@PassportSeries", soldier.@PassportSeries);
                    await command.ExecuteNonQueryAsync();
                }
            }*/
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

            MessageBox.Show("Written successfully!");
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

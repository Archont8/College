using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleTableExt;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Project
{
    public partial class MainForm : MaterialForm
    {
        bool checkingInput = true;
        bool checkingChange = false;
        readonly string connect = "Data Source = RecruitmentOffice.db";
        readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private int ColorIndex;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connect))
            {
                connection.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Soldiers(
                    id INTEGER NOT NULL PRIMARY KEY, 
                    FIO nvarchar(50), 
                    ValidityCategory nvarchar(1), 
                    MilitaryBranch nvarchar(20), 
                    Address nvarchar(30), 
                    PassportNumber nvarchar
                )";
                using (var command = new SQLiteCommand(sql, connection))
                    command.ExecuteNonQuery();
            }
        }
        private void UpdateData()
        {
            SelectTeacherComboBox.Items.Clear();

            using (var connection = new SQLiteConnection(connect))
            {
                connection.Open();

                string sql = @"SELECT * FROM Soldiers";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var rowData = new object[]
                                {
                                    reader[0], reader[1], reader[2], reader[3],
                                    reader[4], reader[5], reader[6], reader[7],
                                    reader[8], reader[9], reader[10], reader[11]
                                };

                                Invoke(new Action(() =>
                                {
                                    TeachersDataGrid.Rows.Add(rowData);
                                    SelectTeacherComboBox.Items.Add(reader[1]);
                                }));
                            }
                        }
                    }
                }
            }
        }

        private void UpdateTablesButton_Click(object sender, EventArgs e)
        {
            Thread update = new Thread(UpdateData);
            update.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void ChangeColorThemeButton_Click(object sender, EventArgs e)
        {
            ColorIndex++;
            if (ColorIndex > 4) 
                ColorIndex = 0;

            switch (ColorIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple500, Primary.Purple600, Primary.Purple400, Accent.DeepPurple200, TextShade.WHITE);
                    break;
            }
        }
        private void AddInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SurnameTXB.Text))
                    throw new NullSurnameException();

                if (string.IsNullOrWhiteSpace(NameTXB.Text))
                    throw new NullNameException();

                if (string.IsNullOrWhiteSpace(SeriespassportTXB.Text))
                    throw new NullSeriesPassportException();

                if (string.IsNullOrWhiteSpace(NumberpassportTXB.Text))
                    throw new NullNumberPassportException();

                using (var connection = new SQLiteConnection(connect))
                {
                    connection.Open();
                    if (checkingInput)
                    {
                        Soldier employee = new Soldier(FIO.Text, AddressTXT.text, ValidityCategoryTXB.text,
                            MilitaryBranchTXB.Text, SeriespassportTXB.Text, NumberpassportTXB.Text);

                        string sql = @"
                        INSERT INTO Soldiers() SELECT @id, @surname, @name, @patronymic, @gender, @datebirthday, @numberphone, @seriespassport, @numberpassport, @hiredate, @salary, @specialization)";
                        int id_teacher = NextIdTeacher();

                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", id_teacher);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Запись успешно добавлена!", "Добавление информации");
                    }
                    else if (checkingChange)
                    {
                        var item = TeachersDataGrid.SelectedRows[0];
                        int id_teacher = Convert.ToInt32(item.Cells[0].Value);
                        Employee employee = new Employee(SurnameTXB.Text, NameTXB.Text, PatronymicTXB.Text, GenderButton1.Checked ? "Мужской" : "Женский", DateBirthdayPick.Value.Date, NumberphoneTXB.Text, SeriespassportTXB.Text, NumberpassportTXB.Text, HireDatePick.Value.Date, (string)SpecializationsList.SelectedItem);

                        string sql = "UPDATE Преподаватели SET Фамилия = @surname, Имя = @name, Отчество = @patronymic, Пол = @gender, 'Дата рождения' = @datebirthday, 'Номер телефона' = @numberphone, 'Серия паспорта' = @seriespassport, 'Номер паспорта' = @numberpassport, 'Дата трудоустройства' = @hiredate, Зарплата = @salary, Специализация = @specialization WHERE id = @id";
                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", id_teacher);
                            command.Parameters.AddWithValue("@surname", employee.Surname);
                            command.Parameters.AddWithValue("@name", employee.Name);
                            command.Parameters.AddWithValue("@patronymic", employee.Patronymic);
                            command.Parameters.AddWithValue("@gender", employee.Gender);
                            command.Parameters.AddWithValue("@datebirthday", employee.DateBirthday);
                            command.Parameters.AddWithValue("@numberphone", employee.NumberPhone);
                            command.Parameters.AddWithValue("@seriespassport", employee.SeriesPassport);
                            command.Parameters.AddWithValue("@numberpassport", employee.NumberPassport);
                            command.Parameters.AddWithValue("@hiredate", employee.HireDate);
                            command.Parameters.AddWithValue("@salary", employee.Salary);
                            command.Parameters.AddWithValue("@specialization", employee.Specializaton);
                            command.ExecuteNonQuery();
                        }

                        sql = "DELETE FROM Дисциплины WHERE id_Преподавателя = @id_teacher";

                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id_teacher", id_teacher);
                            command.ExecuteNonQuery();
                        }

                        sql = "INSERT INTO Дисциплины (id_Дисциплины, Название, 'Рабочие часы', id_Преподавателя) VALUES (@id, @name, @hours, @id_teacher)";

                        foreach (var subject in subjects)
                        {
                            using (var command = new SQLiteCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@id", NextIdSubject());
                                command.Parameters.AddWithValue("@name", subject.Value.Name);
                                command.Parameters.AddWithValue("@hours", subject.Value.Hours);
                                command.Parameters.AddWithValue("@id_teacher", id_teacher);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Запись успешно обновлена!", "Изменение информации");
                        checkingInput = true;
                        checkingChange = false;
                    }
                }
            }
            catch (NullSurnameException) { }
            catch (NullNameException) { }
            catch (NullSeriesPassportException) { }
            catch (NullNumberPassportException) { }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка - {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int NextIdTeacher()
        {
            using (var connection = new SQLiteConnection(connect))
            {
                connection.Open();
                string sql = "SELECT MAX(id) FROM Преподаватели";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    object result = command.ExecuteScalar();
                    return (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                }
            }
        }
        private int NextIdSubject()
        {
            using (var connection = new SQLiteConnection(connect))
            {
                connection.Open();
                string sql = "SELECT MAX(id_Дисциплины) FROM Дисциплины";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    object result = command.ExecuteScalar();
                    return (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                }
            }
        }
        private void ChangeInfoMenu_Click(object sender, EventArgs e)
        {
            checkingInput = false;
            checkingChange = true;
            MainMenu.SelectTab(1);
        }

        private async void DeleteInfoMenu_Click(object sender, EventArgs e) //
        {
            using (var connection = new SQLiteConnection(connect))
            {
                await connection.OpenAsync();
                string sql = "DELETE FROM Дисциплины WHERE id_Преподавателя = @id";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    var param = new SQLiteParameter("@id");
                    foreach (DataGridViewRow item in TeachersDataGrid.SelectedRows)
                    {
                        param.Value = item.Cells[0].Value;
                        command.Parameters.Add(param);
                        await command.ExecuteNonQueryAsync();
                        command.Parameters.Clear(); 
                    }
                }
                sql = "DELETE FROM Преподаватели WHERE id = @id";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    var param = new SQLiteParameter("@id");
                    foreach (DataGridViewRow item in TeachersDataGrid.SelectedRows)
                    {
                        param.Value = item.Cells[0].Value;
                        command.Parameters.Add(param);
                        await command.ExecuteNonQueryAsync();
                        command.Parameters.Clear();
                        TeachersDataGrid.Rows.Remove(item);
                    }
                }
            }
        }

        private void MainMenuSelector_Click(object sender, EventArgs e)
        {
            if (MainMenu.SelectedIndex == 1)
            {
                if (checkingChange)
                {
                    checkingInput = false;
                    checkingChange = true;
                }
                else if (checkingInput)
                {
                    checkingChange = false;
                    checkingInput = true;
                }
            }
        }

        private async void SearchTeachersButton_Click(object sender, EventArgs e)
        {
            SortedTeachersDataGrid.Rows.Clear();
            SortedSubjectsDataGrid.Visible = false;
            SortedTeachersDataGrid.Visible = true;
            using (var connection = new SQLiteConnection(connect))
            {
                await connection.OpenAsync();
                string sql = $"SELECT Преподаватели.id, Преподаватели.Фамилия, Преподаватели.Имя, Преподаватели.Отчество, Преподаватели.Специализация, Дисциплины.'Рабочие часы' FROM Преподаватели JOIN Дисциплины ON Преподаватели.id = Дисциплины.id_Преподавателя WHERE Дисциплины.Название = '{SelectSubjectComboBox.Text}';";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                SortedTeachersDataGrid.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                            }
                        }
                    }
                }
            }
        }

        private async void SearchSubjectsButton_Click(object sender, EventArgs e)
        {
            SortedSubjectsDataGrid.Rows.Clear();
            SortedTeachersDataGrid.Visible = false;
            SortedSubjectsDataGrid.Visible = true;
            using (var connection = new SQLiteConnection(connect))
            {
                await connection.OpenAsync();
                string sql = $"SELECT Дисциплины.id_Дисциплины, Дисциплины.Название, Дисциплины.'Рабочие часы' FROM Преподаватели JOIN Дисциплины ON Преподаватели.id = Дисциплины.id_Преподавателя WHERE Преподаватели.Фамилия = '{SelectTeacherComboBox.Text}';";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            while (await reader.ReadAsync())
                                SortedSubjectsDataGrid.Rows.Add(reader[0], reader[1], reader[2]);
                    }
                }
            }
        }

        private async void InputFileButton_Click(object sender, EventArgs e)
        {
            string SoldiersFile = "SoldiersFile";

            await Task.WhenAll(
                WriteToFileAsync(SoldiersFile, "SELECT * FROM Soldiers;"),
            );
        }

        private async Task WriteToFileAsync(string filePath, string sql)
        {
            try
            {
                using (var SW = new StreamWriter(filePath))
                {
                    using (var connection = new SQLiteConnection(connect))
                    {
                        await connection.OpenAsync();
                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            using (var reader = await command.ExecuteReaderAsync())
                            {
                                if (reader.HasRows)
                                {
                                    var data = new List<List<string>>();
                                    var columns = new List<string>();

                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        columns.Add(reader.GetName(i));
                                    }

                                    while (await reader.ReadAsync())
                                    {
                                        var rows = new List<string>();
                                        foreach (var column in columns)
                                        {
                                            rows.Add(reader[column].ToString());
                                        }
                                        data.Add(rows);
                                    }

                                    var tableString = ConsoleTableBuilder
                                        .From(data)
                                        .WithColumn(columns.ToArray())
                                        .Export();

                                    await SW.WriteLineAsync(tableString.ToString());
                                }
                            }
                        }
                    }
                }
            } catch (UnauthorizedAccessException) {
                MessageBox.Show("Отсутствует разрешение на доступ к файлу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ArgumentException) {
                MessageBox.Show("Недопустимый аргумент, передаваемый в метод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (PathTooLongException) {
                MessageBox.Show("Путь слишком длинный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (DirectoryNotFoundException) {
                MessageBox.Show("Директория не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show($"Ошибка - {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void SurnameTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Фамилия состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NameTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Имя состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatronymicTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Отчество состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchSurnameTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Фамилия состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSubjectTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Предмет состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSortedSurnameTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Фамилия состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSortedSubjectTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Предмет состоит только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
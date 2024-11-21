using System.Windows.Forms;
namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.AddInfoTab = new System.Windows.Forms.TabPage();
            this.AddInfoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SurnameTXB = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PassportGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberpassportLabel = new System.Windows.Forms.Label();
            this.NumberpassportTXB = new System.Windows.Forms.MaskedTextBox();
            this.SeriespassportTXB = new System.Windows.Forms.MaskedTextBox();
            this.SeriespassportLabel = new System.Windows.Forms.Label();
            this.OutputInfoTab = new System.Windows.Forms.TabPage();
            this.SearchTeacherButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.InputFileButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TeachersDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_телефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Серия_паспорта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_паспорта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_трудоустройства = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Зарплата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Специализация_преподавателя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuDB = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.ChangeInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTablesButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SearchSurnameTXB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SubjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.id_Дисциплины = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Рабочие_часы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Преподавателя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainMenu.SuspendLayout();
            this.AddInfoTab.SuspendLayout();
            this.PassportGroupBox.SuspendLayout();
            this.OutputInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataGrid)).BeginInit();
            this.ContextMenuDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.AddInfoTab);
            this.MainMenu.Controls.Add(this.OutputInfoTab);
            this.MainMenu.Depth = 0;
            this.MainMenu.Location = new System.Drawing.Point(0, 63);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.MainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(1123, 597);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.SelectedIndexChanged += new System.EventHandler(this.MainMenuSelector_Click);
            // 
            // AddInfoTab
            // 
            this.AddInfoTab.BackColor = System.Drawing.Color.White;
            this.AddInfoTab.Controls.Add(this.AddInfoButton);
            this.AddInfoTab.Controls.Add(this.SurnameTXB);
            this.AddInfoTab.Controls.Add(this.materialLabel1);
            this.AddInfoTab.Controls.Add(this.SurnameLabel);
            this.AddInfoTab.Controls.Add(this.PassportGroupBox);
            this.AddInfoTab.Location = new System.Drawing.Point(4, 22);
            this.AddInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddInfoTab.Name = "AddInfoTab";
            this.AddInfoTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddInfoTab.Size = new System.Drawing.Size(1115, 571);
            this.AddInfoTab.TabIndex = 1;
            this.AddInfoTab.Text = "Добавление преподавателя";
            // 
            // AddInfoButton
            // 
            this.AddInfoButton.AutoSize = true;
            this.AddInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddInfoButton.Depth = 0;
            this.AddInfoButton.Icon = null;
            this.AddInfoButton.Location = new System.Drawing.Point(450, 474);
            this.AddInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddInfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddInfoButton.Name = "AddInfoButton";
            this.AddInfoButton.Primary = true;
            this.AddInfoButton.Size = new System.Drawing.Size(200, 36);
            this.AddInfoButton.TabIndex = 65;
            this.AddInfoButton.Text = "Добавить информацию";
            this.AddInfoButton.UseVisualStyleBackColor = true;
            this.AddInfoButton.Click += new System.EventHandler(this.AddInfoButton_Click);
            // 
            // SurnameTXB
            // 
            this.SurnameTXB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTXB.Location = new System.Drawing.Point(208, 22);
            this.SurnameTXB.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameTXB.Name = "SurnameTXB";
            this.SurnameTXB.Size = new System.Drawing.Size(179, 26);
            this.SurnameTXB.TabIndex = 52;
            this.SurnameTXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTXB_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(310, 100);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 47;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(119, 23);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(83, 21);
            this.SurnameLabel.TabIndex = 48;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // PassportGroupBox
            // 
            this.PassportGroupBox.Controls.Add(this.NumberpassportLabel);
            this.PassportGroupBox.Controls.Add(this.NumberpassportTXB);
            this.PassportGroupBox.Controls.Add(this.SeriespassportTXB);
            this.PassportGroupBox.Controls.Add(this.SeriespassportLabel);
            this.PassportGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.PassportGroupBox.Location = new System.Drawing.Point(540, 318);
            this.PassportGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassportGroupBox.Name = "PassportGroupBox";
            this.PassportGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.PassportGroupBox.Size = new System.Drawing.Size(375, 105);
            this.PassportGroupBox.TabIndex = 64;
            this.PassportGroupBox.TabStop = false;
            this.PassportGroupBox.Text = "Паспортные данные";
            // 
            // NumberpassportLabel
            // 
            this.NumberpassportLabel.AutoSize = true;
            this.NumberpassportLabel.Location = new System.Drawing.Point(81, 64);
            this.NumberpassportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberpassportLabel.Name = "NumberpassportLabel";
            this.NumberpassportLabel.Size = new System.Drawing.Size(57, 19);
            this.NumberpassportLabel.TabIndex = 25;
            this.NumberpassportLabel.Text = "Номер";
            // 
            // NumberpassportTXB
            // 
            this.NumberpassportTXB.Location = new System.Drawing.Point(151, 64);
            this.NumberpassportTXB.Margin = new System.Windows.Forms.Padding(2);
            this.NumberpassportTXB.Mask = "000000";
            this.NumberpassportTXB.Name = "NumberpassportTXB";
            this.NumberpassportTXB.Size = new System.Drawing.Size(121, 26);
            this.NumberpassportTXB.TabIndex = 22;
            this.NumberpassportTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeriespassportTXB
            // 
            this.SeriespassportTXB.Location = new System.Drawing.Point(151, 28);
            this.SeriespassportTXB.Margin = new System.Windows.Forms.Padding(2);
            this.SeriespassportTXB.Mask = "00 00";
            this.SeriespassportTXB.Name = "SeriespassportTXB";
            this.SeriespassportTXB.Size = new System.Drawing.Size(121, 26);
            this.SeriespassportTXB.TabIndex = 23;
            this.SeriespassportTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeriespassportLabel
            // 
            this.SeriespassportLabel.AutoSize = true;
            this.SeriespassportLabel.Location = new System.Drawing.Point(86, 31);
            this.SeriespassportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeriespassportLabel.Name = "SeriespassportLabel";
            this.SeriespassportLabel.Size = new System.Drawing.Size(52, 19);
            this.SeriespassportLabel.TabIndex = 24;
            this.SeriespassportLabel.Text = "Серия";
            // 
            // OutputInfoTab
            // 
            this.OutputInfoTab.BackColor = System.Drawing.Color.White;
            this.OutputInfoTab.Controls.Add(this.SearchTeacherButton);
            this.OutputInfoTab.Controls.Add(this.InputFileButton);
            this.OutputInfoTab.Controls.Add(this.TeachersDataGrid);
            this.OutputInfoTab.Controls.Add(this.UpdateTablesButton);
            this.OutputInfoTab.Controls.Add(this.SearchSurnameTXB);
            this.OutputInfoTab.Controls.Add(this.SubjectsDataGrid);
            this.OutputInfoTab.Location = new System.Drawing.Point(4, 22);
            this.OutputInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.OutputInfoTab.Name = "OutputInfoTab";
            this.OutputInfoTab.Padding = new System.Windows.Forms.Padding(2);
            this.OutputInfoTab.Size = new System.Drawing.Size(1115, 571);
            this.OutputInfoTab.TabIndex = 2;
            this.OutputInfoTab.Text = "Вывод информации";
            // 
            // SearchTeacherButton
            // 
            this.SearchTeacherButton.AutoSize = true;
            this.SearchTeacherButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchTeacherButton.Depth = 0;
            this.SearchTeacherButton.Icon = null;
            this.SearchTeacherButton.Location = new System.Drawing.Point(9, 11);
            this.SearchTeacherButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchTeacherButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchTeacherButton.Name = "SearchTeacherButton";
            this.SearchTeacherButton.Primary = false;
            this.SearchTeacherButton.Size = new System.Drawing.Size(68, 36);
            this.SearchTeacherButton.TabIndex = 17;
            this.SearchTeacherButton.Text = "Поиск";
            this.SearchTeacherButton.UseVisualStyleBackColor = true;
            // 
            // InputFileButton
            // 
            this.InputFileButton.AutoSize = true;
            this.InputFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InputFileButton.Depth = 0;
            this.InputFileButton.Icon = null;
            this.InputFileButton.Location = new System.Drawing.Point(861, 34);
            this.InputFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputFileButton.Name = "InputFileButton";
            this.InputFileButton.Primary = true;
            this.InputFileButton.Size = new System.Drawing.Size(244, 36);
            this.InputFileButton.TabIndex = 15;
            this.InputFileButton.Text = "Занести информацию в файл";
            this.InputFileButton.UseVisualStyleBackColor = true;
            this.InputFileButton.Click += new System.EventHandler(this.InputFileButton_Click);
            // 
            // TeachersDataGrid
            // 
            this.TeachersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TeachersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TeachersDataGrid.ColumnHeadersHeight = 29;
            this.TeachersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Фамилия,
            this.Имя,
            this.Отчество,
            this.Пол,
            this.Дата_рождения,
            this.Номер_телефона,
            this.Серия_паспорта,
            this.Номер_паспорта,
            this.Дата_трудоустройства,
            this.Зарплата,
            this.Специализация_преподавателя});
            this.TeachersDataGrid.ContextMenuStrip = this.ContextMenuDB;
            this.TeachersDataGrid.Location = new System.Drawing.Point(0, 86);
            this.TeachersDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.TeachersDataGrid.Name = "TeachersDataGrid";
            this.TeachersDataGrid.ReadOnly = true;
            this.TeachersDataGrid.RowHeadersWidth = 51;
            this.TeachersDataGrid.RowTemplate.Height = 24;
            this.TeachersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersDataGrid.Size = new System.Drawing.Size(1114, 442);
            this.TeachersDataGrid.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Фамилия
            // 
            this.Фамилия.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.MinimumWidth = 6;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.ReadOnly = true;
            this.Фамилия.Width = 81;
            // 
            // Имя
            // 
            this.Имя.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Имя.HeaderText = "Имя";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.ReadOnly = true;
            this.Имя.Width = 54;
            // 
            // Отчество
            // 
            this.Отчество.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Отчество.HeaderText = "Отчество";
            this.Отчество.MinimumWidth = 6;
            this.Отчество.Name = "Отчество";
            this.Отчество.ReadOnly = true;
            this.Отчество.Width = 79;
            // 
            // Пол
            // 
            this.Пол.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Пол.HeaderText = "Пол";
            this.Пол.MinimumWidth = 6;
            this.Пол.Name = "Пол";
            this.Пол.ReadOnly = true;
            this.Пол.Width = 52;
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Дата_рождения.HeaderText = "Дата рождения";
            this.Дата_рождения.MinimumWidth = 6;
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.ReadOnly = true;
            this.Дата_рождения.Width = 111;
            // 
            // Номер_телефона
            // 
            this.Номер_телефона.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Номер_телефона.HeaderText = "Номер телефона";
            this.Номер_телефона.MinimumWidth = 6;
            this.Номер_телефона.Name = "Номер_телефона";
            this.Номер_телефона.ReadOnly = true;
            this.Номер_телефона.Width = 118;
            // 
            // Серия_паспорта
            // 
            this.Серия_паспорта.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Серия_паспорта.HeaderText = "Серия паспорта";
            this.Серия_паспорта.MinimumWidth = 6;
            this.Серия_паспорта.Name = "Серия_паспорта";
            this.Серия_паспорта.ReadOnly = true;
            this.Серия_паспорта.Width = 113;
            // 
            // Номер_паспорта
            // 
            this.Номер_паспорта.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Номер_паспорта.HeaderText = "Номер паспорта";
            this.Номер_паспорта.MinimumWidth = 6;
            this.Номер_паспорта.Name = "Номер_паспорта";
            this.Номер_паспорта.ReadOnly = true;
            this.Номер_паспорта.Width = 116;
            // 
            // Дата_трудоустройства
            // 
            this.Дата_трудоустройства.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Дата_трудоустройства.HeaderText = "Дата трудоустройства";
            this.Дата_трудоустройства.MinimumWidth = 6;
            this.Дата_трудоустройства.Name = "Дата_трудоустройства";
            this.Дата_трудоустройства.ReadOnly = true;
            this.Дата_трудоустройства.Width = 146;
            // 
            // Зарплата
            // 
            this.Зарплата.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Зарплата.HeaderText = "Зарплата";
            this.Зарплата.MinimumWidth = 6;
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.ReadOnly = true;
            this.Зарплата.Width = 80;
            // 
            // Специализация_преподавателя
            // 
            this.Специализация_преподавателя.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Специализация_преподавателя.HeaderText = "Специализация";
            this.Специализация_преподавателя.MinimumWidth = 6;
            this.Специализация_преподавателя.Name = "Специализация_преподавателя";
            this.Специализация_преподавателя.ReadOnly = true;
            this.Специализация_преподавателя.Width = 111;
            // 
            // ContextMenuDB
            // 
            this.ContextMenuDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContextMenuDB.Depth = 0;
            this.ContextMenuDB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeInfoMenu,
            this.DeleteInfoMenu});
            this.ContextMenuDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContextMenuDB.Name = "ContextMenuDB";
            this.ContextMenuDB.Size = new System.Drawing.Size(155, 48);
            // 
            // ChangeInfoMenu
            // 
            this.ChangeInfoMenu.Name = "ChangeInfoMenu";
            this.ChangeInfoMenu.Size = new System.Drawing.Size(154, 22);
            this.ChangeInfoMenu.Text = "Редактировать";
            this.ChangeInfoMenu.Click += new System.EventHandler(this.ChangeInfoMenu_Click);
            // 
            // DeleteInfoMenu
            // 
            this.DeleteInfoMenu.Name = "DeleteInfoMenu";
            this.DeleteInfoMenu.Size = new System.Drawing.Size(154, 22);
            this.DeleteInfoMenu.Text = "Удалить";
            this.DeleteInfoMenu.Click += new System.EventHandler(this.DeleteInfoMenu_Click);
            // 
            // UpdateTablesButton
            // 
            this.UpdateTablesButton.AutoSize = true;
            this.UpdateTablesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateTablesButton.Depth = 0;
            this.UpdateTablesButton.Icon = ((System.Drawing.Image)(resources.GetObject("UpdateTablesButton.Icon")));
            this.UpdateTablesButton.Location = new System.Drawing.Point(373, 18);
            this.UpdateTablesButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateTablesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateTablesButton.Name = "UpdateTablesButton";
            this.UpdateTablesButton.Primary = true;
            this.UpdateTablesButton.Size = new System.Drawing.Size(44, 36);
            this.UpdateTablesButton.TabIndex = 10;
            this.UpdateTablesButton.UseVisualStyleBackColor = true;
            this.UpdateTablesButton.Click += new System.EventHandler(this.UpdateTablesButton_Click);
            // 
            // SearchSurnameTXB
            // 
            this.SearchSurnameTXB.Depth = 0;
            this.SearchSurnameTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSurnameTXB.Hint = "Фамилия";
            this.SearchSurnameTXB.Location = new System.Drawing.Point(83, 18);
            this.SearchSurnameTXB.Margin = new System.Windows.Forms.Padding(2);
            this.SearchSurnameTXB.MaxLength = 32767;
            this.SearchSurnameTXB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchSurnameTXB.Name = "SearchSurnameTXB";
            this.SearchSurnameTXB.PasswordChar = '\0';
            this.SearchSurnameTXB.SelectedText = "";
            this.SearchSurnameTXB.SelectionLength = 0;
            this.SearchSurnameTXB.SelectionStart = 0;
            this.SearchSurnameTXB.Size = new System.Drawing.Size(224, 23);
            this.SearchSurnameTXB.TabIndex = 11;
            this.SearchSurnameTXB.TabStop = false;
            this.SearchSurnameTXB.UseSystemPasswordChar = false;
            this.SearchSurnameTXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchSurnameTXB_KeyPress);
            // 
            // SubjectsDataGrid
            // 
            this.SubjectsDataGrid.AllowUserToResizeColumns = false;
            this.SubjectsDataGrid.AllowUserToResizeRows = false;
            this.SubjectsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.SubjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Дисциплины,
            this.Название,
            this.Рабочие_часы,
            this.id_Преподавателя});
            this.SubjectsDataGrid.Location = new System.Drawing.Point(0, 86);
            this.SubjectsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectsDataGrid.Name = "SubjectsDataGrid";
            this.SubjectsDataGrid.ReadOnly = true;
            this.SubjectsDataGrid.RowHeadersWidth = 51;
            this.SubjectsDataGrid.RowTemplate.Height = 24;
            this.SubjectsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectsDataGrid.Size = new System.Drawing.Size(1114, 442);
            this.SubjectsDataGrid.TabIndex = 1;
            this.SubjectsDataGrid.Visible = false;
            // 
            // id_Дисциплины
            // 
            this.id_Дисциплины.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_Дисциплины.HeaderText = "id Дисциплины";
            this.id_Дисциплины.MinimumWidth = 6;
            this.id_Дисциплины.Name = "id_Дисциплины";
            this.id_Дисциплины.ReadOnly = true;
            this.id_Дисциплины.Visible = false;
            // 
            // Название
            // 
            this.Название.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Название.HeaderText = "Название";
            this.Название.MinimumWidth = 6;
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Рабочие_часы
            // 
            this.Рабочие_часы.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Рабочие_часы.HeaderText = "Рабочие часы";
            this.Рабочие_часы.MinimumWidth = 6;
            this.Рабочие_часы.Name = "Рабочие_часы";
            this.Рабочие_часы.ReadOnly = true;
            // 
            // id_Преподавателя
            // 
            this.id_Преподавателя.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_Преподавателя.HeaderText = "id Преподавателя";
            this.id_Преподавателя.MinimumWidth = 6;
            this.id_Преподавателя.Name = "id_Преподавателя";
            this.id_Преподавателя.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 659);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolSync";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.AddInfoTab.ResumeLayout(false);
            this.AddInfoTab.PerformLayout();
            this.PassportGroupBox.ResumeLayout(false);
            this.PassportGroupBox.PerformLayout();
            this.OutputInfoTab.ResumeLayout(false);
            this.OutputInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataGrid)).EndInit();
            this.ContextMenuDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip ContextMenuDB;
        ToolStripMenuItem ChangeInfoMenu;
        ToolStripMenuItem DeleteInfoMenu;
        private MaterialSkin.Controls.MaterialTabControl MainMenu;
        private TabPage AddInfoTab;
        private MaterialSkin.Controls.MaterialRaisedButton AddInfoButton;
        private TextBox SurnameTXB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label SurnameLabel;
        private GroupBox PassportGroupBox;
        private Label NumberpassportLabel;
        private MaskedTextBox NumberpassportTXB;
        private MaskedTextBox SeriespassportTXB;
        private Label SeriespassportLabel;
        private TabPage OutputInfoTab;
        private MaterialSkin.Controls.MaterialFlatButton SearchTeacherButton;
        private MaterialSkin.Controls.MaterialRaisedButton InputFileButton;
        private DataGridView TeachersDataGrid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Фамилия;
        private DataGridViewTextBoxColumn Имя;
        private DataGridViewTextBoxColumn Отчество;
        private DataGridViewTextBoxColumn Пол;
        private DataGridViewTextBoxColumn Дата_рождения;
        private DataGridViewTextBoxColumn Номер_телефона;
        private DataGridViewTextBoxColumn Серия_паспорта;
        private DataGridViewTextBoxColumn Номер_паспорта;
        private DataGridViewTextBoxColumn Дата_трудоустройства;
        private DataGridViewTextBoxColumn Зарплата;
        private DataGridViewTextBoxColumn Специализация_преподавателя;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateTablesButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField SearchSurnameTXB;
        private DataGridView SubjectsDataGrid;
        private DataGridViewTextBoxColumn id_Дисциплины;
        private DataGridViewTextBoxColumn Название;
        private DataGridViewTextBoxColumn Рабочие_часы;
        private DataGridViewTextBoxColumn id_Преподавателя;
    }
}
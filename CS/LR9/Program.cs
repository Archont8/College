using Microsoft.Data.Sqlite;
<<<<<<< Updated upstream
using static System.Console;
class Program {
    public static void Main() {
        try {
            Write("Enter the path to the database: ");
            string path = ReadLine()!;
            using (var connect = new SqliteConnection($"Data Source = {path}")) {
                connect.Open();
                Menu.MainMenu(connect);
=======
using System.Data.Common;
using System.Data;
using static System.Console;
class Program {
    static void Main() {
        Info();
    }
    static public void Info() {
        Write("Enter a path to a database:");
        string path = ReadLine()!;
        string connection = $"Data source = {path}";
        using (var connect = new SqliteConnection(connection)) {
            connect.Open();
            var command = new SqliteCommand();
            command.Connection = connect;
            //WriteLine("Enter the database name: ");
            //string DatabaseName = ReadLine()!;
            //command.CommandText = @$"
            //create database {DatabaseName}
            //";
            WriteLine("\nDatabase has been created\n");
            Selection(command);
            command.CommandText = "";
        }
    }
    static public void Selection(SqliteCommand com) {
        WriteLine(@"What do you want to do?
        1. Create a table
        2. Show data
        3. Insert row
        4. Exit
        ");
        var TableColumns = new Dictionary<string, string>();
        int Selection = Convert.ToInt32(ReadLine());
        switch (Selection) {
            case 1: CreateNewTable(com, TableColumns); break;
            case 2: ShowData(com, TableColumns); break;
            case 3: InsertDataToATable(com, TableColumns); break;
            case 4: Environment.Exit(0); break;
        }
    }
    static public void ShowData(SqliteCommand com, Dictionary<string, string> tableColumns) {
        WriteLine("Select the table to show the data");
        string TableName = ReadLine()!;
        using (SqliteDataReader reader = com.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foreach (var x in tableColumns.Select((value, index) => new {value, index})) {
                    string NameOfColumn = x.value.Key.ToString();
                    var valueOfColumn = reader.GetValue(x.index);
                    WriteLine($"{valueOfColumn}");
                    }
                }
>>>>>>> Stashed changes
            }
        } catch (Exception ex) {
            WriteLine($"Error!: {ex.Message}");
        }
    }
<<<<<<< Updated upstream
=======
    static public void CreateNewTable(SqliteCommand com, Dictionary<string, string> tableColumns) {
        WriteLine("Enter a name of the new table: ");
        string NameOfNewTable = ReadLine()!;
        WriteLine("Enter the quantity of table columns: ");
        int QuantityOfColumns = Convert.ToInt32(ReadLine());
        WriteLine($"Enter a name of the column 1: ");
        string FirstColumnName = ReadLine()!;
        WriteLine($"Enter a type of the column 1: ");
        string FirstColumnType =  ReadLine()!;
        tableColumns.Add(FirstColumnName, FirstColumnType);
        com.CommandText = @$"
        create table {NameOfNewTable} (
        {FirstColumnName} {FirstColumnType}
        )
        ";
        if (QuantityOfColumns > 1) {
            for (int i = 1; i < QuantityOfColumns; ++i) {
                WriteLine($"Enter a name of the column {i+1}: ");
                string NameOfNewColumn = ReadLine()!;
                WriteLine($"Enter a type of the column {i+1}: ");
                string TypeOfNewColumn = ReadLine()!;
                com.CommandText =@$"
                alter table {NameOfNewTable}
                add {NameOfNewColumn} {TypeOfNewColumn}
                ";
            }
        }
    }
    static public void InsertDataToATable(SqliteCommand com, Dictionary<string, string> tableColumns) {
        WriteLine("Select the table to insert the row into");
        string TableName = ReadLine()!;
            foreach (var x in tableColumns) {
                com.CommandText = @$"
                insert into {TableName}({x.Key})
                values ({x.Value})
                ";
            }
    }
>>>>>>> Stashed changes
}
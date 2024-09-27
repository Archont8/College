using Microsoft.Data.Sqlite;
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
            WriteLine("Database has been created\n");
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
            case 1: ShowData(com, TableColumns); break;
            case 2: CreateNewTable(com, TableColumns); break;
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
                    Console.WriteLine($"{valueOfColumn}");
                    }
                }
            }
        }
    }
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
                var dt = new DataTable($"{NameOfNewTable}");
                DataColumn column;
                column = new DataColumn();
                WriteLine($"Enter a name of the field {i}: ");
                string NameOfNewColumn = ReadLine()!;
                WriteLine($"Enter a type of the field {i}: ");
                string TypeOfNewColumn = ReadLine()!;
                tableColumns.Add(NameOfNewColumn, TypeOfNewColumn);
                column.DataType = Type.GetType(TypeOfNewColumn);
                column.ColumnName = NameOfNewColumn;
                dt.Columns.Add(column);
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
}
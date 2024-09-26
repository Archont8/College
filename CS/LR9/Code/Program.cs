using Microsoft.Data.Sqlite;
using static System.Console;
using System.Data;
class Program {
    static void Main() {
        WriteLine("Enter a path to a database:");
        string path = ReadLine()!;
        string connection = $"Data source = {path}";
        using (var connect = new SqliteConnection(connection)) {
            connect.Open();
            var command = new SqliteCommand();
            command.Connection = connect;
            WriteLine("Database has been created\nWould you like to create a table? y/n");
            string ChoiseToCreateATable = ReadLine()!;
            int CountOfTables;
            if (ChoiseToCreateATable == "y") {
                WriteLine("How many tables would you like to create?");
                CountOfTables = Convert.ToInt32(ReadLine()!);
            }   
            if (ChoiseToCreateATable == "n") {
                WriteLine(@"So what do you want to do?\n
                1. See the data of a particular table\n
                2. Create a table\n
                3. Insert the data to a table
                ");
            }
            command.CommandText = "";
        }
    }
    public void ShowData() {}
    public void CreateNewTable(SqliteCommand com, List<string> TableColumns) {
        WriteLine("Enter a name of the new table: ");
        string NameOfNewTable = ReadLine()!;
        WriteLine("Enter the quantity of table columns: ");
        int QuantityOfColumns = Convert.ToInt32(ReadLine());
        WriteLine($"Enter a name of the field 1: ");
        string FirstColumnName = ReadLine()!;
        TableColumns.Add(FirstColumnName);
        WriteLine($"Enter a type of the field 1: ");
        string FirstColumnType =  ReadLine()!;
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
                TableColumns.Add(NameOfNewColumn);
                WriteLine($"Enter a type of the field {i}: ");
                string TypeOfNewColumn = ReadLine()!;
                column.DataType = Type.GetType(TypeOfNewColumn);
                column.ColumnName = NameOfNewColumn;
                dt.Columns.Add(column);
                WriteLine($"\nThe column '{NameOfNewColumn}' has been created.\n");
            }
        }
    }
    /*public void InsertDataToATable(SqliteCommand com, 
    string[] TableFields, string[] Values) {
        if (TableFields.Length == Values.Length) {
            WriteLine("Enter the table name");
            string TableName = ReadLine()!;
            for (int i = 0; i < TableFields.Length; ++i) {
                com.CommandText = @$"
                insert into {TableName}({TableFields[i]})
                values ({Values[i]})
                ";
            }
        }
    }*/
}
//INSERT INTO friends (Nickname, DateOfBirthday) VALUES ($Nickname, $DateOfBirthday)
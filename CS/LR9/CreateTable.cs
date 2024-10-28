using Microsoft.Data.Sqlite;
using static System.Console;

class CreateTable {
    public static void Create(SqliteConnection con, string tableName) {
        if (!ExistTable(con, tableName)) {
            WriteLine("\nEnter the description for the columns (example: id INTEGER NOT NULL PRIMARY KEY, name STRING):");
            string tableColumns = ReadLine()!;
            string sql = $"CREATE TABLE IF NOT EXISTS {tableName} ({tableColumns})";

            using (SqliteCommand command = new(sql, con)) {
                command.ExecuteNonQuery();
                WriteLine();
                WriteLine($@"Таблица ""{tableName}"" создана.");
            }
        } else {
            WriteLine("\nОшибка!\nТакая таблица существует!");
            Menu.MainMenu(con);
        }
    }
    static bool ExistTable(SqliteConnection con, string tableName) {
        using (var command = new SqliteCommand($"PRAGMA table_info({tableName});", con))
        using (var reader = command.ExecuteReader()) {
            if (reader.HasRows) return true;
            else return false;
        }
    }
}
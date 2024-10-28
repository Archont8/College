using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;
using Microsoft.Data.Sqlite;
using static System.Console;

class OutputInfo {
    public static void Output(SqliteConnection con, string TableName) { // Доработать
        try {
            string sql = $"SELECT * FROM {TableName}";

            using (SqliteCommand command = new(sql, con)) {
                SqliteDataReader reader = command.ExecuteReader();
                var table = new Table();
                for (int i = 0; i < reader.FieldCount; i++)
                    table.AddColumn(reader.GetName(i));
                using (reader) {
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            var row = new string[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[i] = Convert.ToString(reader[i])!;
                            table.AddRow(row);
                        }
                    }
                }
                table.Config = TableConfig.MySql();
                Write($"\n{table}");
            }
        } catch (Exception ex) {
            WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
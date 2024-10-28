using Microsoft.Data.Sqlite;
using static System.Console;
class AllTablesDB {
    public static void Tables(SqliteConnection con) {
        WriteLine("\nВсе существующие таблицы в базе данных:");
        string sql = "SELECT * FROM sqlite_master where type='table'";
        using (var command = new SqliteCommand(sql, con)) {
            using (var reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    WriteLine($"{reader.GetString(1)}");
                }
            }
        }
        WriteLine();
    }
}
using System.Data;
using Microsoft.Data.Sqlite;
using static System.Console;
class InputInfo {
    public static void Input(SqliteConnection con, string tableName) {
        
        var ColumnNames = new List<string>();
        WriteLine($"\nВвод данных для таблицы {tableName}\nПоля в таблице:\n");

        string sql = $"PRAGMA table_info({tableName})";

        try {
            using (var command = new SqliteCommand(sql, con)) {
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        ColumnNames.Add(reader.GetString(1));
                        Write($"{reader.GetString(1)} | ");
                    }
                }
            }
            using (SqliteCommand command = new(sql, con)) {
                Write("\n\nEnter the data (examle: 1, 'VladKovalenko'): ");
                string TableValues = ReadLine()!;
                
                sql = $"INSERT INTO {tableName} ({string.Join(", ", ColumnNames)}) VALUES ({string.Join(", ", ColumnNames.Select(c => $"@{c}"))})";
                
                command.CommandText = sql;
                 
                 string[] values = TableValues.Split(',');

                for (int i = 0; i < ColumnNames.Count; i++) {
                    string value = i < values.Length ? values[i].Trim() : "";
                    command.Parameters.AddWithValue($"@{ColumnNames[i]}", value);
                }

                command.ExecuteNonQuery();
                WriteLine(@$"Данные добавлены в таблицу ""{tableName}""");
                WriteLine();
            }
        } catch (Exception ex) {
            WriteLine($"Ошибка при добавлении данных: {ex.Message}");
        }
    }
}
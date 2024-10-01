using Microsoft.Data.Sqlite;
using static System.Console;
class Program {
    public static void Main() {
        try {
            Write("Enter the path to the database: ");
            string path = ReadLine()!;
            using (var connect = new SqliteConnection($"Data Source = {path}")) {
                connect.Open();
                Menu.MainMenu(connect);
            }
        } catch (Exception ex) {
            WriteLine($"Error!: {ex.Message}");
        }
    }
}
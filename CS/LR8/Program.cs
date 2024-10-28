using Microsoft.Data.Sqlite;

string[] allLines = File.ReadAllLines("Import.txt");

string[] neededLines = allLines.ToArray();

string con = "Data Source = db2.db";
using (var connect = new SqliteConnection(con)) {
    connect.Open();
    var command = connect.CreateCommand();
    foreach (var x in neededLines.Select((value, index) => new {value, index})) {
        command.Parameters.AddWithValue("@UserID", x.index);
        command.Parameters.AddWithValue("@Name", x.value);
        command.CommandText = @$"
        insert into Users(UserID, Name) 
        values (@UserID, @Name)
        ";
    }
    command.ExecuteNonQuery();
}
        

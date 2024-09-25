using Microsoft.Data.Sqlite;

string readText = File.ReadAllText("Import.txt");
var listStrLineElements = new List<string>();
listStrLineElements = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
List<string> rowList = listStrLineElements.SelectMany(s => s.Split('\t')).ToList();
string con = "Data Source = db2.db";
using (var connect = new SqliteConnection(con)) {
    // Соединяемся с DB
    connect.Open();
    var command = connect.CreateCommand();
    for (int i = 0; i < 5; ++i) {
        SqliteParameter Name = new SqliteParameter("$Name", rowList[i]);
        command.Parameters.Add(Name);
        command.CommandText = @"
        insert into Users (Name) values ($Name)
        ";
    }
    command.ExecuteNonQuery();
}
        

using System.Diagnostics;
using Microsoft.Data.Sqlite;
struct Program {
    static void Main(){
    #region MainProgram
        Console.Write("Enter the path: ");
        string path = Console.ReadLine()!;
        var con = $"Data Source = {path}";
        using (var connect = new SqliteConnection(con)) {
            connect.Open();
            //Fill(connect);
            var sw = Stopwatch.StartNew();
            DataWithoutTransaction(connect);
            sw.Stop();
            Console.WriteLine($"Time without transaction (ms): {sw.Elapsed.TotalMilliseconds}");
            sw = Stopwatch.StartNew();
            DataWithTransaction(connect);
            sw.Stop();
            Console.WriteLine($"Time with transaction (ms): {sw.Elapsed.TotalMilliseconds}");
            Queries.Query1(connect);
            Queries.Query2(connect);
            Queries.Query3(connect);
        }
    }
    #endregion
    #region Functions
    static void Fill(SqliteConnection con) {
            con.Open();
            for (int i = 0; i < 1000; i++)
            {
            var command = con.CreateCommand();
            command.CommandText = @"INSERT 
            INTO number(ar1, ar2)
            VALUES ($ar1, $ar2)
            ";
                command.Parameters.AddWithValue("$ar1",new Random().Next(1,9));
                command.Parameters.AddWithValue("$ar2",new Random().Next(1,10000));
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
        }
    static void DataWithoutTransaction(SqliteConnection con){
            con.Open();
            Parallel.For(0, 1000, (i) =>
            {
                var command = con.CreateCommand();
                command.CommandText = @"
                SELECT *
                FROM number
                WHERE ar2>1000
                AND ar2<5000
                AND ar%7==0;
            ";
            });
    }

    static void DataWithTransaction(SqliteConnection con){
            con.Open();
            var transaction = con.BeginTransaction();
            Parallel.For(0, 1000, (i)=>
            {
            var command = con.CreateCommand();
            command.CommandText = @"
            SELECT *
            FROM number
            WHERE ar2 > 1000
                AND ar2 < 5000
                AND ar2 % 7==0;
            ";
            command.ExecuteNonQuery();
            });
            transaction.Commit();
        }
    }
    #endregion
    #region Queries
struct Queries {
    public static void Query1(SqliteConnection con) {
        Console.WriteLine("\nFirst query");
        string query = @"SELECT * 
                       FROM number 
                       WHERE ar2 > 1000 
                       AND ar2 < 5000 
                       AND ar2 % 7 == 0;
                       ";
        using (var command = new SqliteCommand(query, con)) {
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            while (reader.Read()) 
                Console.WriteLine($"{reader["ar1"]} -> {reader["ar2"]}");
        }
    }

    public static void Query2(SqliteConnection con) {
        Console.WriteLine("\nSecond query");
         string query = @"SELECT *
                       FROM number
                       WHERE ar2 % 3 = 0 
                       AND ar2 <> 0
                       ORDER BY ar2";
        using (var command = new SqliteCommand(query, con)) {
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            while (reader.Read()) 
                Console.WriteLine($"{reader["ar1"]} -> {reader["ar2"]}");
        }
    }
    
    public static void Query3(SqliteConnection con) {
        Console.WriteLine("\nThird query");
        string query = @"SELECT *
                       FROM person
                       WHERE name LIKE 't%' 
                       AND LENGTH(name) = 3 
                       AND age < 45";
        
        using (var command = new SqliteCommand(query, con)) {
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();
            while (reader.Read()) 
                Console.WriteLine($"{reader["name"]} -> {reader["age"]}");
        }
    }
}
#endregion
using System.Diagnostics;
using Microsoft.Data.Sqlite;
struct Program {
    async static Task Main(){
        Console.Write("Enter the path: ");
        string path = Console.ReadLine()!;
        await using (var connect = new SqliteConnection($"Data Source = {path}")) {
        await connect.OpenAsync();
        string tableNumber = $@"
        create table if not exists number(
        ar1 smallint,
        ar2 smallint
        )";
        await using (SqliteCommand command = new(tableNumber, connect)) {command.ExecuteNonQuery();}
        //await Task.Run(()=>DBfull(connect));
        var stopwatch= Stopwatch.StartNew();
        await Task.Run(()=>NoTransaction(connect));
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        stopwatch = Stopwatch.StartNew();
        await Task.Run(()=>WithTransaction(connect));
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
    }
    async static Task DBfull(SqliteConnection con){
            var rnd = new Random();
            await con.OpenAsync();
            Parallel.For(0, 1000, async i =>
            {
            var command = con.CreateCommand();
            command.CommandText = @"INSERT 
            INTO number(ar1, ar2)
            VALUES ($ar1, $ar2)
            ";
                command.Parameters.AddWithValue("$ar1",rnd.Next(1,9));
                command.Parameters.AddWithValue("$ar2",rnd.Next(1,10000));
                await command.ExecuteNonQueryAsync();
                command.Parameters.Clear();
            });
    }
    static async Task NoTransaction(SqliteConnection con){
            await con.OpenAsync();
            Parallel.For(0, 1000, async i =>
            {
            var command = con.CreateCommand();
            command.CommandText = @"
            SELECT *
            FROM number
            WHERE ar2 > 1000
                AND ar2 < 5000
                AND ar2 % 7==0;
            ";
            await command.ExecuteNonQueryAsync();
            });
    }
    static async Task WithTransaction(SqliteConnection con){
        await con.OpenAsync();
        var transaction = con.BeginTransaction();
        var command = con.CreateCommand();
        command.Transaction = transaction;
        Parallel.For(0, 1000, async i =>
        {
            var command = con.CreateCommand();
            command.CommandText = @"
            SELECT *
            FROM number
            WHERE ar2 > 1000
                AND ar2 < 5000
                AND ar2 % 7==0;
            ";
            await command.ExecuteNonQueryAsync();
        });
        await transaction.CommitAsync();
        transaction = null;
        command = null;
    }
}
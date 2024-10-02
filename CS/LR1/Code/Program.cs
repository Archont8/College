using System.Diagnostics;
using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;

class Recursion {
    static int Rec(int x) {
        if(x <= 18)
            return x + 3;
        else if(x > 18 && x % 3 == 0)
            return x / 3 * Rec(x / 3) + x - 12;
        else
            return Rec(x - 1) + x * x + 5;
    }
    static public int RecSum() {
        int k = 0;
        Parallel.For (1, 10000000, i =>
        {
            bool ch = true;
            int a = Rec(i);
            while (a != 0)
            {
                if (a % 2 == 0)
                    a /= 10;
                else
                {
                    ch = false;
                    break;
                }
            }
            if (ch == true) k++;
        });
        return k;
    }
}

class Program {
    async static Task Main() {
        var TimeOfProgram = new Stopwatch();
        TimeOfProgram.Start();
        var sw = new Stopwatch();
        sw.Start();
        Recursion.RecSum();
        sw.Stop();
        long TimeNoTask = sw.ElapsedMilliseconds;
        sw.Reset();
        sw.Start();
        int resultTask = await Task.Run(Recursion.RecSum);
        sw.Stop();
        long TimeTask = sw.ElapsedMilliseconds;
        var table = new Table("Способ", "Время (мс)", "Результат");
        table.Config = TableConfig.MySql();
        table.AddRow("Без Task", TimeNoTask, Recursion.RecSum());
        table.AddRow("С Task", TimeTask, resultTask);
        Console.Write(table.ToString());
        Console.WriteLine($"\n\nProgram exectuion time: {TimeOfProgram.Elapsed.TotalMilliseconds}");
    }
}
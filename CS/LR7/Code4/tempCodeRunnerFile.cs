class Program {
    public static void Main() {
        int size = 100;
        int N = 5;
        int[] mas = new int[size];
        var rnd = new Random();
        for (int i = 0; i < size; ++i) {
            mas[i] = rnd.Next(-100, 100);
        }
        var Digits = from x in mas.AsParallel()
        orderby x descending
        where x >= 10 && x <= 99 && x % 10 == N
        select x;
        Console.WriteLine("Результаты без использования лямбда выражения:");
        foreach (int i in Digits) {
            Console.WriteLine(i);
        }
        var DigitsLambda = mas.AsParallel()
        .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
        .Where(x => x >= 10 && x <= 99 && x % 10 == N)
        .OrderByDescending(x => x)
        .ToList();
        Console.WriteLine("Результаты с использованием лямбда выражения:");
        foreach (int i in DigitsLambda) {
            Console.WriteLine(i);
        }
    }
}

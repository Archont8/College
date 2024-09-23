fun main() {
    print("a = ");
    val a = readln().toDouble();
    print("b = ");
    val b = readln().toDouble();
    print("n = ");
    val n = readln().toInt();
    val h: Double = (b - a) / n;
    for (i in 0..n) {
        var result = (a + i) * h;
        var res = String.format("%.2f", result)
        println(res);
    }
}
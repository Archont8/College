fun main() {
    print("a = ");
    var a = readln().toInt();
    val results = mutableListOf<Int>();
    var d = 2;
    while (d * d <= a) {
        if (a % d == 0) {
            results.add(d);
            a /= d;
        }
        else {
            d += 1;
        }
    }
    if (a > 1) {
        results.add(a);
    }
    println(results);
}
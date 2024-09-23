fun main() {
    print("x = ");
    val x: Double = readln().toDouble();
    print("y = ");
    val y: Double = readln().toDouble();
    if (x > 0 && y < 0) {
        println("Yes, the point is situated in fourth quarter");
    }
}
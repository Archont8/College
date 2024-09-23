import kotlin.math.roundToInt;

fun main() {
val size = 15;
var count = 0;
val mas = intArrayOf(size);
for (i in mas.indices) {
    mas[i] = Math.random().roundToInt();
}
for (i in mas.indices) {
    if ((mas[i] < mas[i+1]) && (mas[i] < mas[i-1])) {
        ++count;
    }
}
println("Количество локальных минимумов: $count");
}
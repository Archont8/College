import kotlin.math.roundToInt

fun main()
{
    val mas = intArrayOf(15);
    var Count = 0;
    var Multiplication = 1;
    var CountOfZeros = 0;
    for (i in mas.indices) {
        mas[i] = Math.random().roundToInt()
        if (mas[i] < 0) ++Count;
        if (mas[i] == 0) ++CountOfZeros;
        if (mas[i] > 0)
        {
            Multiplication *= mas[i];
        }
    }
    print("Кол-во отрицательных чисел: $Count\t" +
            "Кол-во нулей: $CountOfZeros\t" +
            "Произведение положительных чисел: $Multiplication");
}
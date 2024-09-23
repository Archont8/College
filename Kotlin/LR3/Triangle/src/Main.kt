fun main() {
        val triangle = Triangle(4.0, 1.0, 2.0, 4.0, 3.0, 1.0);
        triangle.Square();
    }

open class Vector {
        var x1: Double = 1.0
        get() = field;
        set(value) {
            field = value;
        }
        var y1: Double = 1.0
        get() = field;
        set(value) {
            field = value;
        }
        var x2: Double = 2.0
        get() = field;
        set(value) {
            field = value;
        }
        var y2: Double = 2.0
        get() = field;
        set(value) {
            field = value;
        }
    constructor(_x1: Double, _y1: Double, _x2: Double, _y2: Double) {
        x1 = _x1;
        y1 = _y1;
        x2 = _x2;
        y2 = _y2;
    }
}
class Triangle(x1: Double, y1: Double, x2: Double, y2: Double,
 x3: Double, y3: Double) : Vector(x1, y1, x2, y2) {
    var x3: Double = 1.0
        get() = field;
        set (value) {
            field = value;
        }
    var y3: Double = 1.0
        get() = field;
        set(value) {
            field = value;
        }
    fun Square() {
        val S: Double = 0.5 * (((x1 - x3) * (y2 - y3)) - ((x2 - x3) * (x1 - x3)));
        print("Square of rectangle is $S");
    } 
} 

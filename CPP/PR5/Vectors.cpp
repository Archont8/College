#include <iostream>
#include <random>
#include <array>
#include <iomanip>
#include "Vectors.h"

using namespace std;

    void Vectors::Initialize() {
        setlocale(LC_ALL, "RU");
        random_device r;
        default_random_engine e(r());
        uniform_int_distribution<int> dist(10, 99);

        int mas[10];
        array<int, 10> masArray;

        for (size_t i = 0; i < 10; ++i) {
            mas[i] = dist(e);
            cout << mas[i] << setw(4);
        }

        cout << endl;

        for (size_t i = 0; i < 10; ++i) {
            masArray[i] = dist(e);
            cout << masArray[i] << setw(4);
        }

        ArrayAndMasShift(mas, masArray);
    }
    void Vectors::ArrayAndMasShift(int mas[], array<int, 10> ar) {
        int tmp = mas[9];
        for (int i = 9; i > 0; --i) {
            mas[i] = mas[i - 1];
        }
        mas[0] = tmp;

        int tmp = ar[9];
        for (int i = 9; i > 0; i--) {
            ar[i] = ar[i - 1];
        }
        ar[0] = tmp;
    }

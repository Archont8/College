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
        uniform_int_distribution<int> dist(0, 1);

        int mas[10];
        array<int, 10> masArray;

        cout << "Arrays before shift:\n";

        for (size_t i = 0; i < 10; ++i) {
            mas[i] = dist(e);
            cout << mas[i] << setw(4);
        }

        cout << endl;

        for (size_t i = 0; i < 10; ++i) {
            masArray[i] = dist(e);
            cout << masArray[i] << setw(4);
        }
        cout << "\n\nArrays after shift: \n\n";



        int firstNumberMas = TransferMas(mas);
        int firstNumberArray = TransferArray(masArray);

        ArrayAndMasShift(mas, masArray);

        for (size_t i = 0; i < 10; ++i) {
            cout << mas[i] << setw(4);
        }

        cout << endl;

        for (size_t i = 0; i < 10; ++i) {
            cout << masArray[i] << setw(4);
        }

        int secondNumberMas = TransferMas(mas);
        int secondNumberArray = TransferArray(masArray);

        int sumMas = firstNumberMas + secondNumberMas;
        int sumArray = firstNumberArray + secondNumberArray;

        cout << endl << endl;
        cout << "Sum of origin and obtained after shift number in C-array: " << sumMas << endl;
        cout << "Sum of origin and obtained after shift number in std::array: " << sumArray << endl;

    }

    void Vectors::ArrayAndMasShift(int mas[], array<int, 10>& ar) {
        int tmp1 = mas[9];
        for (int i = 9; i > 0; --i) {
            mas[i] = mas[i - 1];
        }
        mas[0] = tmp1;

        int tmp2 = ar[9];
        for (int i = 9; i > 0; i--) {
            ar[i] = ar[i - 1];
        }
        ar[0] = tmp2;
    }

    int Vectors::TransferMas(int mas[])
    {
        int value = 0;
        const int binary = 2;

        for (int i = 0; i < 10; i++) {
            if (mas[9 - i] == 1) {
                value += pow(binary, i);
            }
        }
        return value;
    }

    int Vectors::TransferArray(array<int, 10>& ar)
    {
        int value = 0;
        const int binary = 2;

        for (int i = 0; i < 10; i++) {
            if (ar[9 - i] == 1) {
                value += pow(binary, i);
            }
        }
        return value;
    }

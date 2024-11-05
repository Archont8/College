#include <iostream>
#include <random>
#include <vector>
#include <iomanip>
#include "Vectors.h"

using namespace std;

void Vectors::Initialize() {
    setlocale(LC_ALL, "RU");
    random_device r;
    default_random_engine e(r());
    uniform_int_distribution<int> dist(10, 99);

    vector<int> mas(10);

    for (size_t i = 0; i < 10; ++i) {
        mas[i] = dist(e);
        cout <<  mas[i] << setw(3);
    }
    CountOfLocalMinimums(mas);
}
void Vectors::CountOfLocalMinimums(vector<int>& vec) {
    int k = 0;
    for (int i = 1; i < 9; i++) {
        if (vec[i] < vec[i - 1] && vec[i] < vec[i + 1]) ++k;
    }
    cout << "\n\nCount of local minimums: " << k;
}
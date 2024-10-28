#include <iostream>
#include <random>
#include <iomanip>
#include "Vectors.h"

using namespace std;
using namespace Func;

    void Vectors::Initialize() {
        setlocale(LC_ALL, "RU");
        random_device r;
        default_random_engine e(r());
        uniform_int_distribution<int> dist(10, 99);

        vector<int> mas(10);
        for (size_t i = 0; i < mas.size(); ++i) {
            mas[i] = dist(e);
            cout << mas[i] << setw(4);
        }
        Task17(mas);
    }
    void Vectors::Task17(vector<int> ar) {
        int count = 0;
        for (int i = 0; i < ar.size(); ++i)
        {
            if (i == 0 && ar[i] < ar[i + 1]) ++count;
            else if (i > 0 && i < ar.size() - 1 && ar[i] < ar[i - 1] && ar[i] < ar[i + 1]) ++count;
            else if (i == ar.size() - 1 && ar[i] < ar[i - 1]) count++;
        }
        cout << "\n\nКоличество локальных минимумов: " << count << endl;
    }
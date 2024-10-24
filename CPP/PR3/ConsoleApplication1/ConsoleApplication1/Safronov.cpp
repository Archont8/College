/*
* 
* Практичская работа 3
* Создание, вывод и сортировка массива
* Выполнил студент группы И-31 Сафронов Данил
* Проверил: преподаватель Фомин А.Т.
* 
*/

#include <iostream>
#include <iomanip>
#include <random>

using namespace std;

class Program {

	void FillMas(int, int[]);
	void FillArray(array<int, 5>&);
	void QuickSort(int[], int, int, int&);
	void SwapNums(int&, int&);

	int main() {
		const int size = 5;
		int mas[size];
		array<int, 5> ar;
		FillMas(size, mas);
	}

	void FillMas(int size, int mas[]) {
		random_device r;
		default_random_engine e(r());
		uniform_int_distribution<int> dist(1, 100);
		for (size_t i = 0; i < size; ++i) {
			mas[i] = dist(e);
		}
		int k = 0;
		QuickSort(mas, 0, size - 1, k);
		for (size_t i = 0; i < size; ++i) {
			cout << mas[i];
		}
	}
	void FillArray(std::array<int, 5>& ar) {
		random_device r;
		default_random_engine e(r());
		uniform_int_distribution<int> dist(1, 100);

		for (int& i: ar) {
			i = dist(e);
			cout << i << setw(4);
		}
	}

	void SwapNums(int& a, int& b) {
		int temp = a;
		a = b;
		b = temp;
	}

	void QuickSort(int mas[], int l, int r, int& k) {
		int L = l, R = r;
		int M = mas[(l + r) / 2];
		do {
			k++;
			while (mas[l] < M) {
				l++;
			}
			while (mas[r] > M) {
				r--;
			}
			if (l <= r) {
				SwapNums(mas[l], mas[r]);
				l++;
				r--;
			}
		} while (l < r);
		if (L < r)
			QuickSort(mas, L, r, k);
		if (l < R)
			QuickSort(mas, l, R, k);
	}
};


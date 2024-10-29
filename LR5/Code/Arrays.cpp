#include <iostream>
#include <random>
#include <iomanip>
#include "Arrays.h"

using namespace std;

void Arrays::MyArray(int* mas, int size) {
	random_device r;
	default_random_engine e(r());
	uniform_int_distribution<int> dist(10,99);
	cout << endl;
	for (size_t i = 0; i < size; ++i) {
		mas[i] = dist(e);
		cout << mas[i] << setw(4);
	}
	cout << endl;
	delete[] mas;
}

void Arrays::Matrix(int** matrix, int size1, int size2) {
	random_device r;
	default_random_engine e(r());
	uniform_int_distribution<int> dist(10, 99);

	
	for (size_t i = 0; i < size1; ++i) {
		for (size_t j = 0; j < size2; ++j) {
			matrix[i][j] = dist(e);
			cout << matrix[i][j] << setw(4);
		}
		cout << endl;
	}

	for (size_t i = 0; i < size1; ++i) delete[] matrix[i];
	delete[] matrix;
}

void Arrays::ArrayTask(int* mas, int size) {
	cout << endl;
	for (size_t i = 0; i < size; ++i) {
		if (mas[i] % 2 == 0) mas[i] = mas[i];
		cout << mas[i] << setw(4);
	}
	cout << endl;
}

void Arrays::MatrixTask(int** matrix, int size1, int size2) {
	cout << endl;
	for (size_t i = 0; i < size1; ++i) {
		for (size_t j = 0; j < size2; ++j) {
			if (matrix[i][j] == 0) matrix[i] = 0;
			cout << matrix[i][j] << setw(4);
		}
		cout << endl;
	}
	cout << endl;
}

void Arrays::Selection() {
	int size; cout << "Array size: "; cin >> size;
	int* mas = new int[size];

	int size1; cout << "\nMatrix size 1: "; cin >> size1;
	int size2; cout << "Matrix size 2: "; cin >> size2;

	int** matrix = new int* [size1];
	for (size_t i = 0; i < size1; ++i) matrix[i] = new int[size2];

	while (true) {
		cout << "\nIt's time to choose\n";
		cout << "\n1 Fill and print 1D array";
		cout << "\n2 Fill and print 2D array";
		cout << "\n3 Task for 1D array (adding 0 after even numbers)";
		cout << "\n4 Task for 2D array (deleting strings with null elements)\n\n";
		int n; cin >> n;
		switch (n) {
		case 1: MyArray(mas, size); break;
		case 2: Matrix(matrix, size1, size2); break;
		case 3: ArrayTask(mas, size); break;
		case 4: MatrixTask(matrix, size1, size2); break;
		}
	}
}
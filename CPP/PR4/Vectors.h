#pragma once
#ifndef VECTORS_H
#define VECTORS_H
#include <vector>
#include <array>

	class Vectors
	{
	public:
		static void Initialize();
	private:
		static void ArrayAndMasShift(int[], std::array<int, 10>&);
		static int TransferMas(int[]);
		static int TransferArray(std::array<int, 10>&);
	};
#endif

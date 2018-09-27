#include "pch.h"
#include <iostream>

using namespace std; 


int euklidesGame(int A, int B); 
int main()
{
	cout << euklidesGame(2, 4); 
}
int euklidesGame(int A, int B) {
	int count = 0;

	if (A == B)
	{
		count = A + B;
	}

	if (A > B)
	{
		int difference = A - B;
		count = A - difference;
	}
	if (B > A)
	{
		int difference = B - A;
		count = B - difference;
	}
	return count;
}

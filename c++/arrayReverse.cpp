
#include "pch.h"
#include <iostream>

using namespace std; 

int main()
{
	int array[10] = { 7, 1, 2, 3, 4, 5, 6, 7 };
	reverse(begin(array), end(array)); 
	for (int i = 0; i < 10; i++) {
		cout << array[i]; 
	}
}


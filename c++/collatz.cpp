#include "pch.h"
#include <iostream>

using namespace std; 

int main()
{
	int n = 0; 
	int steps = 1; 

	cout << "Enter a number greater than 0: "; 

	cin >> n; 

	while (n != 1) {
		if (n % 2 == 0)
		{
			n = n / 2;
		}
		else {
			n = n * 3 + 1;
		}
		steps++;
		cout << n; 
	}
}


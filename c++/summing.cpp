#include "pch.h"
#include <iostream>

using namespace std; 

int main()
{
	int sum = 0;
	int i = 1;

	while (true) {
		cout << "Enter a number: "; 
		int number; 
		cin >> number; 
		if (number == 0)
		{
			break;
		}
		sum += number; 
		i += 1;
		cout << sum << "\n"; 
	}
}



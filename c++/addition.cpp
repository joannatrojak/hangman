
#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	cout << "How many numbers do you want to add? "; 
	int count; 
	cin >> count; 
	int sum = 0; 

	while (count > 0) {
		int number; 
		cin >> number; 
		sum += number; 
		count--; 
		cout << sum; 
	}
}

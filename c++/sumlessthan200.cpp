#include "pch.h"
#include <iostream>

using namespace std; 

int main()
{
	cout << "Give me two numbers less than 200: "; 
	int a, b; 
	int sum; 
	cin >> a >> b; 

	if (a || b < 200) {
		sum = a + b; 
		cout << sum; 
	}
}

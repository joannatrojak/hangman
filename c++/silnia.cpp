
#include "pch.h"
#include <iostream>
#include <string>

using namespace std;



int factorial(int n); 
void digits(int n);
int main()
{
	int n; 
	cout << "Give me a number: "; 
	cin >> n; 
	cout << factorial(n);
	digits(n);
}
int factorial(int n) {
	int factorial  = 1;

	if (n <= 1) {
		return 1;
	}

	for (int i = 1; i < n; i++) {
		factorial = factorial * i;
	}
	return factorial;
}
void digits(int n) {
	int m = factorial(n);
	if (n > 9) {
		cout << "0 0";
	}
	else {
		string numberAsString = to_string(factorial(n));
		int length = numberAsString.length();
		
		if (length >= 2) {
			cout << numberAsString[length - 2] + " " + numberAsString[length - 1];
		}
		else {
			cout << "0 " + numberAsString[length - 1];
		}
	}
}

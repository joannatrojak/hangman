#include "pch.h"
#include <iostream>
#include <string>

using namespace std;


void power(int a, int b); 
int main()
{
	double a, b;
	cout << "Give me the power: "; 
	cin >> a >> b;
	power(a, b);
}
void power(int a, int b) {
	int power = pow(a, b);
	string numberAsString = to_string(power);
	int length = numberAsString.length();

	if (length == 1) {
		cout << power;
	}

	if (length > 1) {
		cout << numberAsString[length - 1];
	}
}


#include "pch.h"
#include <iostream>

using namespace std; 

int delta(double a, double b, double c); 
int main()
{
	cout << "Give me a, b, c: "; 
	double a, b, c; 
	cin >> a >> b >> c; 
	cout << delta(a, b, c); 
}
int delta(double a, double b, double c) {
	double delta = pow(b, 2) - 4 * a * c;

	if (delta > 0)
	{
		return 2;
	}
	if (delta == 0)
	{
		return 1;
	}
	if (delta < 0)
	{
		return 0;
	}
	return -1; 
}


#include "pch.h"
#include <iostream>
#include <math.h>

using namespace std; 

int main()
{
	const double pi = 3.141592654; 
	int d, r; 
	cout << "Give me d and r: "; 
	cin >> d >> r; 
	double area = floor(((pow(d, 2)) - (pow(r, 2) / 4)) * pi); 
	cout << area; 
}


#include "pch.h"
#include <iostream>

using namespace std; 

int silnia(int n); 
int pascalTriangle(int n, int k); 
int main()
{
	cout << pascalTriangle(7, 3); 
}
int silnia(int n) {
	int r = 1;
	for (int i = 1; i < n + 1; i++)
	{
		r = r * i;
	}
	return r;
}
int pascalTriangle(int n, int k) {
	return silnia(n) / (silnia((n - k)) * silnia(k));
}

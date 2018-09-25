#include "pch.h"
#include <iostream>

using namespace std; 

int nwd(int n, int m); 
int nww(int n, int m);
int main()
{
	cout << nww(12, 15);
}
int nwd(int n, int m) {
	while (m != 0) {
		int temp = m;
		m = n % m;
		n = temp;
	}
	return n; 
}
int nww(int n, int m) {
	return (n*m) / nwd(n, m); 
}

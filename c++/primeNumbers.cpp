

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	int n; 
	cout << "Give me a number: \n";
	cin >> n; 

	if (n < 2) {
		cout << "NIE";
	}

	for (int i = 2; i < n; i++) {
		if (n % i == 0) {
			cout << "NIE";
		}
		cout << "TAK";
	}
}


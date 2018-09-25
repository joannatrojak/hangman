
#include "pch.h"
#include <iostream>
#include <string>


using namespace std; 

string reverse(string n); 
string palindrome(int n);

int main()
{
	cout << palindrome(28);
}
string reverse(string n) {
	string str = n; 
	reverse(str.begin(), str.end());
	return str; 
}
string palindrome(int n) {
	int count = 0; 
	while (to_string(n) != reverse(to_string(n))) {
		n = n + atoi(reverse(to_string(n)).c_str());
		count += 1; 

	}
	return to_string(n) + " " + to_string(count);
}



#include "pch.h"
#include <iostream>
#include <string>

using namespace std; 

int main()
{
	string s1, s2;
	string merged;
	s1 = "abc";
	s2 = "def";

	for (int i = 0; i < s1.length(); i++) {
		merged += s1[i]; 
		merged += s2[i]; 
	}
	cout << merged; 
	
}

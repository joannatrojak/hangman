#include "pch.h"
#include <vector> 
#include <string> 
#include <algorithm> 
#include <sstream> 
#include <iterator> 
#include <iostream> 
#include <map>

using namespace std;



int main()
{
	string letters = "ABBBCDEF"; 
	int count = 1;
	char ch;
	vector <char> result; 
	for (int i = 0; i < letters.size(); i++) {
		if (letters[i] == letters[i + 1] ) {
			ch = letters[i];
			count += 1;
			if (count > 2) {
				ch = letters[i];
				string s = to_string(count); 
				char const *pchar = s.c_str();
				result.push_back(ch);
				result.push_back(*pchar);
			}
			else if (count <= 2) {
				ch = letters[i];
				result.push_back(ch);
			}
		}
		else {
			ch = letters[i];
			result.push_back(ch);
		}
	}
	for (std::vector<char>::const_iterator i = result.begin(); i != result.end(); ++i)
		std::cout << *i << ' ';

}



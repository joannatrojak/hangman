#include "pch.h"
#include <iostream>

using namespace std; 

double glutton(int time); 
double howManyBoxes(int box, int gluttons[2]); 
int main()
{
	int array[2] = { 3600, 1800 }; 
	cout << howManyBoxes(10, array); 
}
double glutton(int time) {
	return 86400 / time;
}
double howManyBoxes(int box, int gluttons[2]) {
	int sum = 0; 
	for (int i = 0; i < 2; i++)
	{
		sum += glutton(gluttons[i]);
	}
	double boxes = sum / box;
	return boxes;
}

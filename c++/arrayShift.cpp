#include "pch.h"
#include <iostream>

using namespace std; 


void leftRotatebyOne(int arr[], int n); 
void leftRotate(int arr[], int d, int n); 
void printArray(int arr[], int n); 
int main()
{
	int array[] = { 7, 1, 2, 3, 4, 5, 6, 7 };
	int n = sizeof(array) / sizeof(array[0]);
	
	leftRotate(array, 2, n);
	printArray(array, n);
}
void leftRotatebyOne(int arr[], int n)
{
	int temp = arr[0], i;
	for (i = 0; i < n - 1; i++)
		arr[i] = arr[i + 1];

	arr[i] = temp;
}
void leftRotate(int arr[], int d, int n)
{
	for (int i = 0; i < d; i++)
		leftRotatebyOne(arr, n);
}
void printArray(int arr[], int n)
{
	for (int i = 0; i < n; i++)
		cout << arr[i] << " ";
}


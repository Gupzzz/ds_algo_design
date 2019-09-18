#include<iostream>

using namespace std;

void BubbleSort(int* values, int size);

int main()
{
	int values[6] = {10, 20, 90, 30, 80, 50};
	
	for(int i = 0; i < 6; i++){
		cout << values[i] << "\t";
	}
	cout << endl;

	BubbleSort(values, 6);

	for(int i = 0; i < 6; i++){
		cout << values[i] << "\t";
	}
	cout << endl;

	return 0;
}	

void BubbleSort(int* values, const int size)
{
	for(int i = 0; i < size; i++){
		for(int j = 0; j < 5 - i; j++){
			if(values[j] > values[j + 1]){
				int temp = values[j];
				values[j] = values[j + 1];
				values[j + 1] = temp;
			}
		}
	}
}

#import <iostream>

using namespace std;

void QuickSort(int* values, int size);

int main(){
	int values[6] = {10, 20, 90, 30, 80, 50};
	
	for(int i = 0; i < 6; i++){
		cout << values[i] << "\t";
	}
	cout << endl;

	QuickSort(values, 6);

}

void QuickSort(int* values, const int size){
	cout << "Testing" << endl;

}

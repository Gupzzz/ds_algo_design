#include <iostream>

#include "Tweeter.h"

// using declarations
using std::cout;
using std::cin;
using std::string;
using std::endl;

int main()
{
	int number = 12;
	bool prime = true;
	int i = 2;

	while (i <= number / i) {
		cout << i << endl;
		int factor = number / i;
		if (factor * i == number) {
			cout << i << " * " << factor << endl;
			prime = false;
		}
		i++;
	}
	if (prime) cout << "Prime";

	/*Tweeter tweeter;
	Tweeter t1("Dhivya", "Mohan", 23, "@dvya");*/

	//Person p1("Arun", "Guptha", 25);
	/*{
		Tweeter t1("Dhivya", "Mohan", 23, "@dvya");
		string name = t1.getName();
	}*/
	//string name = p1.getName();

	/*enum Status {
		Pending,
		Approved
	};

	enum class FileError {
		Approved,
		AttributeError
	};

	Status status = Pending;
	FileError fe = FileError::Approved;*/

	return 0;
}

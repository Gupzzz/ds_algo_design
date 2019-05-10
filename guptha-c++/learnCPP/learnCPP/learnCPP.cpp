#include <iostream>

#include "Person.h"
#include "Tweeter.h"

// using declarations
using std::cout;
using std::cin;
using std::string;

int main()
{
	Tweeter tweeter;
	Tweeter t1("Dhivya", "Mohan", 23, "@dvya");

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

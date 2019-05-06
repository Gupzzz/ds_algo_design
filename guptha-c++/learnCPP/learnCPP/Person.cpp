#include "Person.h"

#include <iostream>
using std::cout;
using std::cin;
using std::string;

string Person::getName() {
	return firstname + " " + lastname;
}

Person::Person(string first, string last, int arbitrary)
	:
	firstname(first),
	lastname(last),
	arbitrarynumber(arbitrary)
{
	cout << "constructing person " << getName() << std::endl;
}

Person::Person()
	:
	arbitrarynumber(0)
{
	cout << "constructing person " << getName() << std::endl;
}

Person::~Person()
{
	cout << "destructing person " << std::endl;
}

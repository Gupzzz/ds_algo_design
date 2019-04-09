#include "Person.h"

#include <iostream>
using std::cout;
using std::cin;

std::string Person::getName() {
	return firstname + " " + lastname;
}

Person::Person(std::string first, std::string last, int arbitrary)
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

#include "Tweeter.h"
#include <iostream>

//using declarations
using std::cout;
using std::cin;


Tweeter::Tweeter()
{
	cout << "constructing Empty Tweeter " << std::endl;
}

Tweeter::Tweeter(std::string first, std::string last, int arbitrary, std::string handle)
	:
	Person(first, last, arbitrary),
	twitterhandle(handle)
{
	cout << "constructing Tweeter " << getName() << " Handle: " << twitterhandle << std::endl;
}


Tweeter::~Tweeter()
{
	cout << "destructing tweeter " << twitterhandle << std::endl;
}

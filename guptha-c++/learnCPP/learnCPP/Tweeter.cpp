#include "Tweeter.h"
#include <iostream>

//using declarations
using std::cout;
using std::cin;


Tweeter::Tweeter()
{
}

Tweeter::Tweeter(std::string first, std::string last, int arbitrary, std::string handle)
	:
	Person(first, last, arbitrary),
	twitterhandle(handle)
{
	cout << "constructing tweeter " << getName() << " Handle: " << twitterhandle << std::endl;
}


Tweeter::~Tweeter()
{
	cout << "destructing tweeter " << twitterhandle << std::endl;
}

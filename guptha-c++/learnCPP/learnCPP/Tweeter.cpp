#include "Tweeter.h"
#include <iostream>

//using declarations
using std::cout;
using std::cin;
using std::string;


Tweeter::Tweeter()
{
	cout << "constructing Empty Tweeter " << std::endl;
}

Tweeter::Tweeter(string first, string last, int arbitrary, string handle)
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

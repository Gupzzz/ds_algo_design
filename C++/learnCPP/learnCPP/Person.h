#pragma once
#include <string>

class Person
{
private:
	std::string firstname;
	std::string lastname;
	int arbitrarynumber;

public:
	std::string getName();
	Person(std::string first, std::string last, int arbitrary);
	Person();
	~Person();
};
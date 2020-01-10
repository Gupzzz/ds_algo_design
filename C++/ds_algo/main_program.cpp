#include <iostream>
#include <vector>
#include <string>

using namespace std;

int main()
{
    vector<string> msg{ "Arun", "C++", "Guptha", "from", "VS Code", "and the C++ extension!" };
    
    for (const string& word : msg)
    {
        cout << word << " ";
    }
    cout << endl;
}
#include<iostream>
using namespace std;

int main()
{
	string input;
	cin >> input;

	string output;
	for (int i = 0; i < input.length(); i++)
	{
		if (islower(input[i]))
			output += toupper(input[i]);
		else if (isupper(input[i]))
			output += tolower(input[i]);
	}
	cout << output;

	return 0;
}
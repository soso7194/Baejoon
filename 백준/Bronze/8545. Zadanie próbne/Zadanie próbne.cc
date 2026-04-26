#include<iostream>
using namespace std;

int main()
{
	string input;
	cin >> input;

	string str;
	for (int i = input.length() - 1; i >= 0; i--)
	{
		str += input[i];
	}

	cout << str;
	return 0;
}
#include<iostream>
using namespace std;

int main()
{
	long a, b, c = 0;
	cin >> a >> b >> c;
	if (a + b == c)
		cout << "correct!";
	else
		cout << "wrong!";
	return 0;
}
#include <iostream>
#include <stack>

using namespace std;

int main()
{
	int t;
	cin >> t;
	while (t > 0)
	{
		stack<int> s;
		string n;
		bool b = true;
		cin >> n;
		for (int i = 0; i < n.size(); i++)
		{
			if (n[i] == '(')
				s.push(1);
			else
			{
				if (s.size() == 0)
				{
					b = false;
					break;
				}
				s.pop();
			}
		}
		if (s.size() != 0)
			b = false;
		cout << ((b == true) ? "YES" : "NO") << "\n";
		--t;
	}
}

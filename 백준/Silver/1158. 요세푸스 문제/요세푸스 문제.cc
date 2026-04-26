#include<iostream>
#include<queue>

using namespace std;

int main()
{
	int n, num;
	queue<int> q;
	cin >> n >> num;
	for (int i = 1; i <= n; i++)
		q.push(i);
	cout << "<";
	while (q.size() > 0)
	{
		for (int i = 1; i < num; i++)
		{
			q.push(q.front());
			q.pop();
		}
		if (q.size() == 1)
		{
			cout << q.front() << ">";
			q.pop();
		}
		else
		{
			cout << q.front() << ", ";
			q.pop();
		}
	}
}
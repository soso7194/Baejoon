#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() 
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int n = 0, m = 0, output = 0;
	cin >> n;
	int* arr = new int[n];
	for(int i = 0; i < n; i++)
		cin >> arr[i];
	sort(arr, arr + n);
	for(int i = 0; i < n; i++)
	{
		m += arr[i];
		output += m;
	}
	cout << output;

	delete[] arr;
}
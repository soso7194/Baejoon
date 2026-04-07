#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() 
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int n = 0, m = 0;
	cin >> n;
	int* arr = new int[n * n];
	for(int i = 0; i < n * n; i++) 
	{
		cin >> m;
		arr[i] = m;
	}
	sort(arr, arr + n*n);
	reverse(arr, arr + n * n);
	cout << arr[n - 1];

	delete[] arr;
}
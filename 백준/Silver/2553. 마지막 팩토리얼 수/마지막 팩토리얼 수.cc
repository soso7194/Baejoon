#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() 
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

    long long n = 0;
    cin >> n;
    long long m = 1;
    for (long long i = 1; i <= n; i++)
    {
        m *= i;
        m %= 1000000000;
        while (m % 10 == 0)
        {
            m /= 10;
        }
    }
	cout << m % 10 << "\n";
}
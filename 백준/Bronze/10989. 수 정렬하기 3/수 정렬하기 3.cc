#include <iostream>
using namespace std;

int arr[10001];

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int n;
    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int x;
        cin >> x;
        arr[x]++;
    }

    for(int i = 1; i <= 10000; i++)
    {
        while(arr[i]--)
        {
            cout << i << '\n';
        }
    }
}
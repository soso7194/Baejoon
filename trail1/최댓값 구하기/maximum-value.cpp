#include <iostream>
using namespace std;

int main()
{
    int a, b, c;
    cin >> a >> b >> c;

    int maxValue = a;

    if (b > maxValue)
    {
        maxValue = b;
    }

    if (c > maxValue)
    {
        maxValue = c;
    }

    cout << maxValue << endl;
    return 0;
}

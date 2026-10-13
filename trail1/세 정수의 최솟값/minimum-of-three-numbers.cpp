#include <iostream>
using namespace std;

int main()
{
    int a, b, c;
    cin >> a >> b >> c;

    int minValue = (a < b) ? a : b;
    minValue = (minValue < c) ? minValue : c;

    cout << minValue << endl;
    return 0;
}

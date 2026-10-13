#include <iostream>
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;

    int maxValue = (a > b) ? a : b;
    cout << maxValue << endl;
    return 0;
}

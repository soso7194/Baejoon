#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    char c;
    double a, b;
    cin >> c >> a >> b;

    cout << c << endl;
    cout << fixed << setprecision(2);
    cout << a << endl;
    cout << b << endl;
    return 0;
}
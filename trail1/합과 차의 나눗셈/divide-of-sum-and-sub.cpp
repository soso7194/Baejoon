#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;

    double result = (double)(a + b) / (a - b);

    cout << fixed << setprecision(2);
    cout << result << endl;
    return 0;
}

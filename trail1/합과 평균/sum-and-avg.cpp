#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;

    int sum = a + b;
    double avg = sum / 2.0;

    cout << fixed << setprecision(1);
    cout << sum << " " << avg << endl;
    return 0;
}

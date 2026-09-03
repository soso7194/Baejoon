#include <iostream>
using namespace std;

int main() {
    cout << fixed;
    cout.precision(1);

    float a = 9.2, b = 1.3, ft = 30.48, mi = 160934;

    cout << a << "ft = " << a * ft << "cm\n" << b << "mi = " << b * mi <<"cm";
    return 0;
}
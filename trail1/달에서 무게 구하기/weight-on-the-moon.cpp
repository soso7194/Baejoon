#include <iostream>
using namespace std;

int main() {
    cout << fixed;

    cout.precision(6);
    int a = 13;
    double b = 0.165000;
    cout << a << " * " << b << " = " << a * b;
    return 0;
}
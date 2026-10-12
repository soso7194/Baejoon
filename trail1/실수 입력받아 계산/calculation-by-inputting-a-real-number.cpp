#include <iostream>
using namespace std;

int main() {
    float a, b;
    cout.precision(2);
    cout << fixed;
    cin >> a >> b;
    cout << a + b;
    return 0;
}
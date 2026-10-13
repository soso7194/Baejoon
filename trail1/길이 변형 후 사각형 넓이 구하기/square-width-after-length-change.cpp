#include <iostream>
using namespace std;

int main()
{
    int w, h;
    cin >> w >> h;

    w += 8;
    h *= 3;

    cout << w << endl;
    cout << h << endl;
    cout << w * h << endl;
    return 0;
}

#include <iostream>
using namespace std;

int main()
{
    int aMath, aEnglish, bMath, bEnglish;
    cin >> aMath >> aEnglish;
    cin >> bMath >> bEnglish;

    cout << (aMath > bMath && aEnglish > bEnglish) << endl;
    return 0;
}

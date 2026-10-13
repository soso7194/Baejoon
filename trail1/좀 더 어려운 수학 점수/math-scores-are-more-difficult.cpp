#include <iostream>
using namespace std;

int main()
{
    int aMath, aEnglish, bMath, bEnglish;
    cin >> aMath >> aEnglish;
    cin >> bMath >> bEnglish;

    if (aMath > bMath || (aMath == bMath && aEnglish > bEnglish))
    {
        cout << "A" << endl;
    }
    else
    {
        cout << "B" << endl;
    }

    return 0;
}

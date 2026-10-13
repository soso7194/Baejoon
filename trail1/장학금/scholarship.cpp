#include <iostream>
using namespace std;

int main()
{
    int midterm, final;
    cin >> midterm >> final;

    if (midterm >= 90 && final >= 95)
    {
        cout << 100000 << endl;
    }
    else if (midterm >= 90 && final >= 90)
    {
        cout << 50000 << endl;
    }
    else
    {
        cout << 0 << endl;
    }

    return 0;
}

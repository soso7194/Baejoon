#include <iostream>
using namespace std;

int main()
{
    int gender, age;
    cin >> gender >> age;

    if (gender == 0)
    {
        if (age >= 19)
        {
            cout << "MAN" << endl;
        }
        else
        {
            cout << "BOY" << endl;
        }
    }
    else
    {
        if (age >= 19)
        {
            cout << "WOMAN" << endl;
        }
        else
        {
            cout << "GIRL" << endl;
        }
    }

    return 0;
}

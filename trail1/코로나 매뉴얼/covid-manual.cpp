#include <iostream>
using namespace std;

int main()
{
    char s1, s2, s3;
    int t1, t2, t3;
    cin >> s1 >> t1;
    cin >> s2 >> t2;
    cin >> s3 >> t3;

    int count = 0;

    if (s1 == 'Y' && t1 >= 37)
    {
        count++;
    }

    if (s2 == 'Y' && t2 >= 37)
    {
        count++;
    }

    if (s3 == 'Y' && t3 >= 37)
    {
        count++;
    }

    if (count >= 2)
    {
        cout << "E" << endl;
    }
    else
    {
        cout << "N" << endl;
    }

    return 0;
}

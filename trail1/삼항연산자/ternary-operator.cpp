#include <iostream>
#include <string>
using namespace std;

int main()
{
    int score;
    cin >> score;

    string result = (score == 100) ? "pass" : "failure";
    cout << result << endl;
    return 0;
}

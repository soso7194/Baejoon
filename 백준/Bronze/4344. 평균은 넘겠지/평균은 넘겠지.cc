#include <iostream>
#include <vector>
#include <algorithm>
#include <iomanip>

using namespace std;

int main() {
	int num = 0;
	cin >> num;
	for (int i = 0; i < num; i++)
	{
		int input = 0;
		cin >> input;
		double sum = 0;
		vector<double> scores(input);
		for (int i = 0; i < input; i++)
		{
			cin >> scores[i];
			sum += scores[i];
		}
		double average = sum / input;
		int count = 0;
		for (int i = 0; i < input; i++)
		{
			if (scores[i] > average)
				count++;
		}
		double result = (double)count / input * 100;
		cout << fixed << setprecision(3) << result << "%" << endl;
	}
    return 0;
}

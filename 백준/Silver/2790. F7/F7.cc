#include <iostream>
#include <algorithm>
using namespace std;

int N;
int arr[300000];
int maxL[300000], maxR[300000];
int ans;

int main() {
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	cin >> N;
	for (int i = 0; i < N; i++) cin >> arr[i];
	sort(arr, arr + N);
	
	maxL[0] = arr[0] + N - 1;
	for (int i = 1; i < N; i++) maxL[i] = max(arr[i] + (N - 1) - i, maxL[i - 1]);
	
	maxR[N - 1] = arr[N - 1] + 1;
	for (int i = N - 2; i > -1; i--) maxR[i] = max(arr[i] + (N - i), maxR[i + 1]);

	if (arr[0] + N >= maxR[1]) ans++;
	for (int i = 1; i + 1 < N; i++) {
		if (maxL[i - 1] <= arr[i] + N && arr[i] + N >= maxR[i + 1]) ans++;
	}
	if (maxR[N - 2] < arr[N - 1] + N) ans++;

	cout << ans;
}
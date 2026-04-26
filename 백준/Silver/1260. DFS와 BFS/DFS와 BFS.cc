#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>

using namespace std;

int N, M, V;
vector<int> graph[1001];
bool visited[1001];

void dfs(int node) {
    cout << node << " ";
    visited[node] = true;

    for (int& i : graph[node])
        if (!visited[i])
            dfs(i);
}

void bfs(int start) {
    queue<int> q;

    q.push(start);
    visited[start] = true;

    while (!q.empty())
    {
        int m = q.front();
        q.pop();
        cout << m << " ";
        for (int& i : graph[m])
        {
            if (!visited[i])
            {
                q.push(i);
                visited[i] = true;
            }
        }
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    cin >> N >> M >> V;

    for (int i = 0; i < M; i++) {
        int a, b;
        cin >> a >> b;
        graph[a].push_back(b);
        graph[b].push_back(a);
    }

    for (int i = 1; i <= N; i++) {
        sort(graph[i].begin(), graph[i].end());
    }

    dfs(V);
    cout << "\n";

    fill(visited, visited + 1001, false);
    bfs(V);

    return 0;
}
using System;
using System.Collections.Generic;

class Program
{
    static int n, m;
    static char[,] map;
    static bool[,] visited;
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    static void Main()
    {
        var input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        m = int.Parse(input[1]);

        map = new char[n, m];
        visited = new bool[n, m];

        int startX = 0, startY = 0;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < m; j++)
            {
                map[i, j] = line[j];
                if (map[i, j] == 'I')
                {
                    startX = i;
                    startY = j;
                }
            }
        }

        int result = BFS(startX, startY);

        Console.WriteLine(result == 0 ? "TT" : result);
    }

    static int BFS(int x, int y)
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((x, y));
        visited[x, y] = true;

        int count = 0;

        while (q.Count > 0)
        {
            var (cx, cy) = q.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = cx + dx[i];
                int ny = cy + dy[i];

                if (nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
                if (visited[nx, ny]) continue;
                if (map[nx, ny] == 'X') continue;

                visited[nx, ny] = true;

                if (map[nx, ny] == 'P')
                    count++;

                q.Enqueue((nx, ny));
            }
        }

        return count;
    }
}
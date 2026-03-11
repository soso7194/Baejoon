            List<(int, int)> list = new List<(int, int)> ();
            for(int i = 0; i < 8; i++)
            {
                int n = int.Parse(Console.ReadLine());
                list.Add((n, i + 1));
            }
            list.Sort((a, b) => b.Item1.CompareTo(a.Item1));

            int add = 0;
            int[] pos = new int[5];
            for(int i = 0; i < 5; i++)
            {
                add += list[i].Item1;
                pos[i] = list[i].Item2;
            }
            Array.Sort(pos);
            Console.WriteLine(add);
            Console.WriteLine(string.Join(" ", pos));
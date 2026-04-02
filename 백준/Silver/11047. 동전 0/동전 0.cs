            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = 0, count = 0;
            List<int> list = new List<int>(n[0]);
            for(int i = 0; i < n[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            list.Sort();
            while (m != n[1])
            {
                if (n[1] - m < list[list.Count() - 1])
                    list.RemoveAt(list.Count() - 1);
                else
                {
                    m += list[list.Count() - 1];
                    count++;
                }
            }
            Console.WriteLine(count);
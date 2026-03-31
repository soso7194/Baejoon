            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }

            List<string> list = new List<string>(set);

            list.Sort((a, b) =>
            {
                if (a.Length == b.Length)
                    return a.CompareTo(b);
                return a.Length - b.Length;
            });

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
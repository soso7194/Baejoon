            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> list = new List<int>();
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int i in arr)
            {
                list.Add(i);
            }
            list.Sort();
            list.Reverse();
            Console.WriteLine(list[n[1] - 1]);
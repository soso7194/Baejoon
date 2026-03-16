            while (true)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if(arr[0] == 0 && arr[1] == 0)
                    break;
                int count = 0;
                HashSet<int> set = new HashSet<int>();
                for (int i = 0; i < arr[0]; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    set.Add(num);
                }
                for (int i = 0; i < arr[1]; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (set.Contains(num))
                        count++;
                }
                Console.WriteLine(count);
            }
            while (true)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (n[0] == 0 && n[1] == 0 && n[2] == 0)
                    break;
                int[] arr = new int[n.Length];
                for(int i = 0; i < n.Length; i++)
                {
                    arr[i] = n[i];
                }

                Array.Sort(arr);

                int x = arr[0] * arr[0];
                int y = arr[1] * arr[1];
                int z = arr[2] * arr[2];

                if (x + y == z)
                    Console.WriteLine("right");
                else
                    Console.WriteLine("wrong");
            }
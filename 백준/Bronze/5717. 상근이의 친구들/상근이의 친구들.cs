            while (true)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if(arr[0] == 0 && arr[1] == 0)
                    break;
                Console.WriteLine(arr[0] + arr[1]);
            }
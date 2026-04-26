            float n = int.Parse(Console.ReadLine());
            float[] arr = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
            float max = arr.Max();
            float x = 0;

            for (int i = 0; i < n; i++)
            {
                x += arr[i] / max * 100;
            }
            Console.WriteLine(x/n);
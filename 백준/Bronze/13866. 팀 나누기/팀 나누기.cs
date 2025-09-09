            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(n);

            int a = n[0] + n[3];
            int b = n[1] + n[2];

            if(a > b)
                Console.WriteLine(a - b);
            else
                Console.WriteLine(b - a);
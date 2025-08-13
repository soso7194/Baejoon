            int i = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int max = arr.Max();
            int min = arr.Min();

            Console.WriteLine($"{min} {max}");
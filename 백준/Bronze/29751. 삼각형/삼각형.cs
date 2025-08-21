            double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            double area = n[0] * n[1] / 2;
            Console.WriteLine(area.ToString("F1"));
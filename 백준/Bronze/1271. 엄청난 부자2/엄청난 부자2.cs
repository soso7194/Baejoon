using System.Numerics;            

BigInteger[] n = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);

            Console.WriteLine(n[0] / n[1]);
            Console.WriteLine(n[0] % n[1]);
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr[0] + arr[1] - arr[2]);

            string[] str = new string[3];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = arr[i].ToString();
            }
            string n = str[0] + str[1];
            int n1 = int.Parse(n);
            int n2 = int.Parse(str[2]);
            Console.WriteLine(n1 - n2);
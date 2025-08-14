            string input = Console.ReadLine().Trim();
            if(input == "")
                Console.WriteLine(0);
            else
                Console.WriteLine(input.Split().Length);
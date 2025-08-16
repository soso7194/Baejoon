using System.Text;

int i = int.Parse(Console.ReadLine());

            for(int j = 0; j < i; j++)
            {
                string input = Console.ReadLine();
                StringBuilder sb = new StringBuilder(input.Length);
                sb.Append(input[0]);
                if(input.Length > 1)
                {
                    sb.Append(input[input.Length - 1]);
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    sb.Append(input[0]);
                    Console.WriteLine(sb.ToString());
                }
            }
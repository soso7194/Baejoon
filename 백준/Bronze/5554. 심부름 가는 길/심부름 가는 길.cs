        int n = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int a = n + n1 + n2 + n3;

        int b = a / 60;
        int c = a - (b * 60);

        Console.WriteLine(b);
        Console.WriteLine(c);
int n = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;
int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

foreach (var i in m)
{
    if (i == 0)
    {
        y++;
    }
}

if(y > n/2)
{
    Console.WriteLine("INVALID");
}
else
{
    foreach (var i in m)
    {
        x += i;
    }

    if (x > 0)
    {
        Console.WriteLine("APPROVED");
    }
    else
    {
        Console.WriteLine("REJECTED");
    }
}
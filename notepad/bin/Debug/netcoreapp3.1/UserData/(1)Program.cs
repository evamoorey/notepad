using System;
class Program
{
    public static void Main(string[] args)
    {
        int res = 0;
        int x = 1;
        while (x!=0)
        {
            x = int.Parse(Console.ReadLine());
            if ((x < 100 || x > 150) && x != 121)
                Console.WriteLine("Incorrect number");
            else
            {
                if (x >= max)
                {
                    res = max;
                    max = x;
                }
                else if (x >= res)
                    res = x;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(res);
    }
}
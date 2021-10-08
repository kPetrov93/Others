using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            int startN = n;
            int pokes = 0;

            while (n>=m)
            {
                n -= m;
                pokes++;
                if (n==startN/2&&y>0&&y<=n)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokes);

        }
    }
}

using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += currentNum;
                }
                else
                {
                    odd += currentNum;
                }
            }
            int diff = Math.Abs(odd - even);
            if (odd==even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}

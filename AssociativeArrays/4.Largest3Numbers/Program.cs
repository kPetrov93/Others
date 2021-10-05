using System;
using System.Linq;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sorted = num.OrderByDescending(n => n).ToArray();

            if (num.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ",sorted));
            }
        }
    }
}

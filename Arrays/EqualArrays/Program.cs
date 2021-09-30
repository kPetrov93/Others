using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int sum = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    sum += first[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}

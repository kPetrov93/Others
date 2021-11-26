using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = num[0];
            int power = num[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bomb)
                {
                    for (int j = i - power; j <= i + power; j++)
                    {
                        if (j < 0 || j >= input.Count)
                        {
                            continue;
                        }
                        
                       input[j] = 0;
                        
                    }
                }
            }
            Console.WriteLine(input.Sum());

        }
    }
}

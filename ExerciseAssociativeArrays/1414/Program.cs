using System;
using System.Collections.Generic;
using System.Linq;

namespace _1414
{
    class Program
    {
        public static object Dictonary { get; private set; }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> sorted = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!sorted.ContainsKey(item))
                {
                    sorted.Add(item, 0);
                }
                sorted[item]++;
            }

            foreach (var item in sorted)
            {
                if (item.Value%2==1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}

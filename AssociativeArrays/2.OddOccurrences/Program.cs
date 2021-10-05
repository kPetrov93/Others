using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> input = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (input.ContainsKey(word))
                {
                    input[word]++;
                }
                else
                {
                    input.Add(word, 1);
                }
            }
            foreach (var word in input)
            {
                if (word.Value%2==1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}

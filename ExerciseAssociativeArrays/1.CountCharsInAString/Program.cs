using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    string currentWord = input[i];
                    char currentLetter = currentWord[j];

                    if (!dict.ContainsKey(currentLetter))
                    {
                        dict.Add(currentLetter, 0);
                    }
                    dict[currentLetter]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

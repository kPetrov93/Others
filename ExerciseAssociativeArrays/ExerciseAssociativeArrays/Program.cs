using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseAssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (input != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, 0);
                }
                dict[input] += value;

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
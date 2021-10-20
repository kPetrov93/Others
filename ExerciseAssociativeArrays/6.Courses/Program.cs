using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Dictionary<string, int> count = new Dictionary<string, int>();
            while (input!="end")
            {
                string[] sorted = input.Split(" : ").ToArray();
                string course = sorted[0];
                string name = sorted[1];

                if (!dict.ContainsKey(course))
                {
                    dict.Add(course, name);
                    count.Add(course, 1);
                }
                else
                {
                    dict[course] += name;
                    count[course]++;
                }

                input = Console.ReadLine();
            }
            foreach (var item in count.OrderByDescending(x=>x.Key).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");


            }
            foreach (var word in dict)
            {
                Console.WriteLine($"--{word.Value}");
            }

        }
    }
}

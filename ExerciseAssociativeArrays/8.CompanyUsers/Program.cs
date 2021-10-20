using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (input!="End")
            {
                string[] sorted = input.Split(" -> ");
                string company = sorted[0];
                string id = sorted[1];

                if (!dict.ContainsKey(company))
                {
                    dict.Add(company, new List<string>());
                }
                if (!dict[company].Contains(id))
                {
                    dict[company].Add(id);
                }


                input = Console.ReadLine();
            }
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
                
            }
        }
    }
}

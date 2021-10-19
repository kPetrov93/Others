using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            dict.Add("shards", 0);
            dict.Add("fragments", 0);
            dict.Add("motes", 0);
            bool isFound = false;
            string item = string.Empty;
            string[] input = Console.ReadLine().ToLower().Split().ToArray();
            while (!isFound)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string matts = input[i + 1].ToLower();

                    if (matts == "motes" || matts == "fragments" || matts == "shards")
                    {
                        dict[matts] += quantity;

                        if (dict[matts]>= 250)
                        {
                            dict[matts] -= 250;
                            item = matts;
                            isFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(matts))
                        {
                            junk.Add(matts, 0);
                        }
                        
                        junk[matts] += quantity;
                    }
                }
                if (isFound)
                {
                    break;
                }
                else
                {
                    input = Console.ReadLine().ToLower().Split().ToArray();
                } 
            }

            if (item == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (item == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (item == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            foreach (var word in dict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
                
            }

            foreach (var junks in junk.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{junks.Key}: {junks.Value}");
            }
        }
    }
}

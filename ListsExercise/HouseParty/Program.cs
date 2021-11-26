using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> all = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                string action = input[2];
                bool isHere = false;

                if (action == "going!")
                {
                    for (int j = 0; j < all.Count; j++)
                    {
                        if (all[j] == name)
                        {
                            Console.WriteLine($"{name} is already in the list!");
                            isHere = true;
                            break;
                        }
                    }
                    if (isHere == false)
                    {
                        all.Add(name);
                    }
                }
                else if (action == "not")
                {
                    for (int j = 0; j < all.Count; j++)
                    {
                        if (all[j] == name)
                        {
                            all.Remove(name);
                            isHere = true;
                            break;
                        }
                    }
                    if (isHere == false)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int k = 0; k < all.Count; k++)
            {
                Console.WriteLine(all[k]);
            }
        }
    }
}

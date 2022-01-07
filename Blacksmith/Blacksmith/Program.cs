using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            var steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            SortedDictionary<string, int> swords = new SortedDictionary<string, int>();

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currentSteel = steel.Peek();
                int currentCarbon = carbon.Peek();
                int sum = currentSteel + currentCarbon;
                if (sum == 70)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Gladius"))
                    {
                        swords.Add("Gladius", 0);
                    }

                    swords["Gladius"]++;
                }
                else if (sum == 80)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Shamshir"))
                    {
                        swords.Add("Shamshir", 0);
                    }

                    swords["Shamshir"]++;
                }
                else if (sum == 90)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Katana"))
                    {
                        swords.Add("Katana", 0);
                    }

                    swords["Katana"]++;
                }
                else if (sum == 110)
                {
                    carbon.Pop();
                    steel.Dequeue();
                    if (!swords.ContainsKey("Sabre"))
                    {
                        swords.Add("Sabre", 0);
                    }

                    swords["Sabre"]++;
                }
                else if (sum == 150)
                {
                    carbon.Pop();
                    steel.Dequeue();
                    if (!swords.ContainsKey("Broadsword"))
                    {
                        swords.Add("Broadsword", 0);
                    }

                    swords["Broadsword"]++;
                }
                else
                {
                    steel.Dequeue();
                    int current = carbon.Pop();
                    carbon.Push(current + 5);
                }
            }

            if (swords.Count > 0)
            {
                int totalCount = 0;
                foreach (var item in swords)
                {
                    int current = item.Value;
                    totalCount += current;
                }

                Console.WriteLine($"You have forged {totalCount} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }

            if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: " + string.Join(", ", steel));
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: " + string.Join(", ", carbon));
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            if (swords.Count > 0)
            {
                
                foreach (var item in swords)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

        }
    }
}

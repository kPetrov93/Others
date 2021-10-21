using System;
using System.Collections.Generic;
using System.Linq;

namespace _7777
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string user = input[1];
                

                if (command=="register")
                {
                    string licensePlate = input[2];
                    if (!dict.ContainsKey(user))
                    {
                        dict.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }
                    else
                    {

                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (command=="unregister")
                {
                    
                    if (dict.ContainsKey(user))
                    {
                        dict.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int num = int.Parse(commandArgs[1]);

                if (action == "Delete")
                {

                    for (int i = 0; i < input.Count; i++)
                    {

                        input.Remove(num);
                    }
                    
                }
                else if (action=="Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    input.Insert(index, num);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}

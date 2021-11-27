using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Add")
                {
                    int num = int.Parse(commandArgs[1]);
                    input.Add(num);

                }
                else
                {
                    int num = int.Parse(commandArgs[0]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] + num <= max)
                        {
                            input[i] += num;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}

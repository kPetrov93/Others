using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Add")
                {
                    int num = int.Parse(commandArgs[1]);
                    numbers.Add(num);
                }
                else if (action == "Insert")
                {
                    int num = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index >= numbers.Count||index<0)
                    {
                        Console.WriteLine("Invalid index");
                        
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= numbers.Count||index<0)
                    {
                        Console.WriteLine("Invalid index");
                        
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    string direction = commandArgs[1];
                    int num = int.Parse(commandArgs[2]);

                    if (direction == "left"||direction=="Left")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int currentNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(currentNum);
                        }
                    }
                    else if (direction == "right"||direction=="Right")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int currentNum = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, currentNum);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}

using System;

namespace _13._02Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            while (isTrue)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    isTrue = false;
                    break;
                }
                string budget = Console.ReadLine();
                if (budget == "End")
                {
                    isTrue = false;
                    break;
                }

                double budget2 = double.Parse(budget);
                double total = 0;
                while (total < budget2)
                {
                    string input = Console.ReadLine();
                    if (input == "End")
                    {
                        isTrue = false;
                        break;
                    }
                    double input2 = double.Parse(input);
                   
                    total += input2;
                    if (total >= budget2)
                    {
                        total = 0;
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}

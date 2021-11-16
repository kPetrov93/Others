using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;
            while (input != "NoMoreMoney")
            {
                double num = double.Parse(input);
                if (num > 0)
                {
                    Console.WriteLine($"Increase: {num:f2}");
                    total += num;
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}

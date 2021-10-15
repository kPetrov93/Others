using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "m")
            {
                if (output == "cm")
                {
                    Console.WriteLine($"{num * 100:f3}");
                }
                else if (output == "mm")
                {
                    Console.WriteLine($"{num * 1000:f3}");
                }
            }
            else if (input == "cm")
            {
                if (output == "m")
                {
                    Console.WriteLine($"{num / 100:f3}");
                }
                else if (output == "mm")
                {
                    Console.WriteLine($"{num * 10:f3}");
                }
            }
            else if (input == "mm")


            {
                if (output == "cm")
                {
                    Console.WriteLine($"{num / 10:f3}");
                }
                else if (output == "m")
                {
                    Console.WriteLine($"{num / 1000:f3}");
                }
            }
                }
    }
}

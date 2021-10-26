using System;

namespace lecture8
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm")
            {
                if (output == "m")
                {
                    Console.WriteLine($"{value / 1000:f3}");
                }

                else if (output == "cm")
                {
                    Console.WriteLine($"{value / 10:f3}");
                }
            }

            else if (input == "m")
            {
                if (output == "mm")
                {
                    Console.WriteLine($"{value *1000:f3}");
                }
                else if (output == "cm")
                {
                    Console.WriteLine($"{value *100:f3}");
                }
            }

            else if (input == "cm")
            {
                if (output == "mm")
                {
                    Console.WriteLine($"{value * 10:f3}");
                }
                else if (output == "m")
                {
                    Console.WriteLine($"{value /100:f3}");
                }
            }
        }
    }
}

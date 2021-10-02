using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double area = a * b * c;
            double total = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                double n = double.Parse(input);
                total += n;
                if (area - total <= 0)
                {
                    break;
                }
            }
            if (area >= total)
            {
                Console.WriteLine($"{area - total} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {total-area} Cubic meters more.");
            }

        }
    }
}

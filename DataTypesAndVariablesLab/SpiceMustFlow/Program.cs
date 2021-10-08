using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int total = 0;
            int days = 0;

            while (yield >= 100)
            {
                total += yield;
                if (total > 26)
                {
                    total -= 26;
                }
                days++;
                yield -= 10;
            }

            if (total>26)
            {
                total -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}

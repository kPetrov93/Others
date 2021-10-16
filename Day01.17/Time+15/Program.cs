using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int min = minutes + 15;
            if (min >= 60)
            {
                hours = hours + 1;
                if (hours >= 24)
                {
                    hours = hours - 24;
                    min = min - 60;
                    Console.WriteLine($"{hours}:{min:d2}");
                }
                else
                {
                    min = min - 60;
                    Console.WriteLine($"{hours}:{min:d2}");
                }
            }
            else
            {

                if (hours >= 24)
                {
                    hours = hours - 24;
                    min = min - 60;
                    Console.WriteLine($"{hours}:{min:d2}");
                }
                else if (min<=60)
                {
                    Console.WriteLine($"{hours}:{min:d2}");
                }
                else
                {
                    min = min - 60;
                    Console.WriteLine($"{hours}:{min:d2}");
                }
            }
        }
    }
}

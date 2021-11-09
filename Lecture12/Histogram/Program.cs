using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 += 1;
                }
                else if (200 <= num && num <= 399)
                {
                    p2 += 1;
                }
                else if (400 <= num && num <= 599)
                {
                    p3 += 1;
                }
                else if (600 <= num && num <= 799)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }
            }
            double per1 = p1 / n * 100;
            double per2 = p2 / n * 100;
            double per3 = p3 / n * 100;
            double per4 = p4 / n * 100;
            double per5 = p5 / n * 100;

            Console.WriteLine($"{per1:f2}%");
            Console.WriteLine($"{per2:f2}%");
            Console.WriteLine($"{per3:f2}%");
            Console.WriteLine($"{per4:f2}%");
            Console.WriteLine($"{per5:f2}%");
        }
    }
}

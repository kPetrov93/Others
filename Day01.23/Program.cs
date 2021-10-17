using System;

namespace Day01._23
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double weekends = 48;
            double backHome = weekends - h;
            double sofia = backHome * 3 / 4;
            double celeb = p * 2 / 3;
            double total =sofia + h + celeb;

            if (year=="leap")
            {
                total =Math.Floor(total * 1.15);
                Console.WriteLine(total);  
            }
            else
            {
                total = Math.Floor(total);
                Console.WriteLine(total);
            }

        }
    }
}

using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string proj = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double ticket = 0;
            if (proj == "Premiere")
            {
                ticket = 12;
            }
            else if (proj=="Normal")
            {
                ticket = 7.5;
            }
            else if (proj=="Discount")
            {
                ticket = 5;
            }
            Console.WriteLine($"{ticket*r*c:f2} leva");
        }
    }
}

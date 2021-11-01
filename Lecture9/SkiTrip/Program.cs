using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string mark = Console.ReadLine();
            int nights = 0;
            double price = 0;
            double bonus = 0;
            if (days>1)
            {
                nights = days - 1;
            }
            if (room == "room for one person")
            {
                price = 18;
            }
            else if (room == "apartment")
            {
                price = 25;
                if (days < 10)
                {
                    price = 25 - (25 * 0.3);
                }
                else if (days >= 10 && days < 16)
                {
                    price = 25 - (25 * 0.35);
                }
                else if (days > 15)
                {
                    price = 25 - (25 * 0.5);
                }
            }
            else if (room == "president apartment")
            {
                price = 35;
                if (days < 10)
                {
                    price = 35 - (35 * 0.1);
                }
                else if (days >= 10 && days < 16)
                {
                    price = 35 - (35 * 0.15);
                }
                else if (days > 15)
                {
                    price = 35 - (35 * 0.2);
                }
            }
            double total = nights * price;
            if (mark == "positive")
            {
                bonus = total + (total * 0.25);
            }
            else if (mark=="negative")
            {
                bonus = total - (total * 0.1);
            }
            Console.WriteLine($"{bonus:f2}");
        }
    }
}

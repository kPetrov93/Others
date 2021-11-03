using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double price = 0;
            string place = "";
            if (season=="summer")
            {
                place = "Camp";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = budget * 0.30;
                }
                else if (budget<=1000)
                {
                    destination = "Balkans";
                    price = budget * 0.40;
                }
                else
                {
                    destination = "Europe";
                    price = budget * 0.9;
                    place = "Hotel";
                }
            }
            else if (season=="winter")
            {
                place = "Hotel";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = budget * 0.70;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    price = budget * 0.80;
                }
                else
                {
                    destination = "Europe";
                    price = budget * 0.9;
                    place = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}

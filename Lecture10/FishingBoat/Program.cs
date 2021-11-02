﻿using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int guys = int.Parse(Console.ReadLine());
            double rent = 0;
            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }
            if (guys <= 6)
            {
                rent = rent * 0.9;
            }
            else if (7 <= guys && guys <= 11)
            {
                rent = rent * 0.85;
            }
            else if (guys>=12)
            {
                rent = rent * 0.75;
            }
            if (guys % 2 == 0 && season != "Autumn")
            {
                rent = rent * 0.95;
            }
            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {budget - rent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rent-budget:f2} leva.");
            }
        }
    }
}

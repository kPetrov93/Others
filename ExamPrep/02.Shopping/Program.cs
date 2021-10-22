using System;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videoCards = double.Parse(Console.ReadLine());
            double processors = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());

            double priceVideo = 250 * videoCards;
            double priceProcess = (priceVideo * 0.35)*processors;
            double priceRam = (priceVideo * 0.10)*ram;
            double total = priceVideo + priceRam + priceProcess;

            if (videoCards > processors)
            {
                total = total * 0.85;
            }

            if (total<=budget)
            {
                Console.WriteLine($"You have {budget-total:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total-budget:f2} leva more!");
            }
        }
    }
}

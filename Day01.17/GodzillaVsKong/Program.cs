using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stats = int.Parse(Console.ReadLine());
            double cloths = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (stats > 150)
            {
                cloths = cloths * 0.9;
            }
            double total =decor + (cloths * stats);

            if (total>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-total:f2} leva left.");
            }

        }
    }
}

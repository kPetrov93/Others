using System;

namespace Godzilla
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double stats = double.Parse(Console.ReadLine());
            double clothsPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            if (stats > 150)
            {
                clothsPrice = clothsPrice - (clothsPrice * 0.1);
            }

            double leftover = Math.Abs(budget - ((stats * clothsPrice) + decor));



            if (budget >= ((stats * clothsPrice) + decor))

            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftover:f2} leva left.");
            }
            
            else 
            {
                
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {leftover:f2} leva more.");
            }




        }
    }
}

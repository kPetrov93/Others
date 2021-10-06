using System;

namespace Alcohole
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWiskey = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double wiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWiskey * 0.5;
            double priceWine = priceRakia - (priceRakia * 0.4);
            double priceBeer = priceRakia - (priceRakia * 0.8);
            double total = (priceWiskey*wiskey) + (priceWine*wine) + (priceRakia*rakia) + (priceBeer*beer);

            Console.WriteLine($"{total:f2}");

        }
    }
}

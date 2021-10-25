using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesP = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            double raspberriesP = strawberriesP / 2;
            double orangesP = raspberriesP * 0.60;
            double bananasP = raspberriesP * 0.20;

            double total = strawberries * strawberriesP + bananas * bananasP + oranges * orangesP + raspberries * raspberriesP;

            Console.WriteLine($"{total:f2}");



        }
    }
}

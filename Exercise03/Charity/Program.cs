using System;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesP = cakes * 45;
            double wafflesP = waffles * 5.80;
            double pancakesP = pancakes * 3.20;
            double total = days * bakers* (cakesP + wafflesP + pancakesP);
            double money = total - (total * 0.125);

            Console.WriteLine($"{money:f2}");


        }
    }
}

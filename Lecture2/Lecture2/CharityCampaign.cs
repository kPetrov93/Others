using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesP = cakes * 45;
            double wafflesP = waffles * 5.80;
            double pancakesP = pancakes * 3.20;

            double total = days * (cooks * (cakesP + wafflesP + pancakesP));
            double discount = total / 8;
            Console.WriteLine(total-discount);


        }
    }
}

using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double puzzlesP =puzzles*2.60;
            double dollsP =dolls*3;
            double bearsP =bears* 4.10;
            double minionsP =minions* 8.20;
            double trucksP = trucks * 2;
            int num = puzzles + dolls + bears + minions + trucks;
            double total = puzzlesP + dollsP + bearsP + minionsP + trucksP;
            if (num >= 50)
            {
                double disc = total * 0.75;
                double totalP = disc * 0.90;
                if (totalP >= trip)
                {
                    Console.WriteLine($"Yes! {totalP - trip:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {trip - totalP:f2} lv needed.");
                }
            }
            else
            {
                double totalP = total * 0.90;
                if (totalP >= trip)
                {
                    Console.WriteLine($"Yes! {totalP - trip:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {trip - totalP:f2} lv needed.");
                }
            }
        }
    }
}

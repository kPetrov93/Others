using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int timesSpend = 0;
            int days = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                days++;

                if (action=="spend")
                {
                    money -= amount;
                    if (money<=0)
                    {
                        money = 0;
                    }

                    timesSpend++;
                    if (timesSpend>=5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else if (action=="save")
                {
                    timesSpend = 0;
                    money += amount;
                    if (money>=vacationPrice)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
                
                
            }

        }
    }
}

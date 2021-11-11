using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int coins = 0;
            double total = sum;

            while (total>0)
            {
                if (total >= 2)
                {
                    total = total - 2.00;
                    coins++;
                    continue;
                }
                else if (total >= 1)
                {
                    total = total - 1.00;
                    coins++;
                    continue;
                }
                else if (total >= 0.50 && total < 1)
                {
                    total = total - 0.50;
                    coins++;
                    continue;
                }
                else if (total >= 0.20 && total < 0.495)
                {
                    total = total - 0.20;
                    coins++;
                    continue;
                }
                else if (total>=0.10&& total<0.195)
                {
                    total = total - 0.10;
                    coins++;
                    continue;
                }
                else if (total >= 0.05 && total < 0.095)
                {
                    total = total - 0.05;
                    coins++;
                    continue;
                }
                else if (total >= 0.0195 && total < 0.05)
                {
                    total = total - 0.02;
                    coins++;
                    continue;
                }
                else if (total < 0.0190&& total>0.005)
                {
                    total = total - 0.01;
                    coins++;
                    continue;
                   
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(coins);
        }
    }
}

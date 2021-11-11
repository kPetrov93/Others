using System;

namespace CoinsWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int cents = (int)(change * 100);
            int coins = 0;

            while (cents>0)
            {
                if (cents - 200 >= 0)
                {
                    cents -= 200;
                    coins++;
                }
                else if (cents - 100 >= 0)
                {
                    cents -= 100;
                    coins++;
                }
                else if (cents - 50 >= 0)
                {
                    cents -= 50;
                    coins++;
                }
                else if (cents - 20 >= 0)
                {
                    cents -= 20;
                    coins++;
                }
                else if (cents-10>=0)
                {
                    cents -= 10;
                    coins++;
                }
                else if (cents - 5 >= 0)
                {
                    cents -= 5;
                    coins++;
                }
                else if (cents - 2 >= 0)
                {
                    cents -= 2;
                    coins++;
                }
                else if (cents - 1 >= 0)
                {
                    cents -= 1;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}

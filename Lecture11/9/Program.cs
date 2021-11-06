using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double washingP = double.Parse(Console.ReadLine());
            double toyP = double.Parse(Console.ReadLine());
            double saved = 0;
            double money = 10;
            double toys = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    saved += money;
                    saved -= 1;
                    money += 10;
                }
                else
                {
                    toys += 1;
                }

            }
            double total = saved + (toys * toyP);
            if (total >= washingP)
            {
                Console.WriteLine($"Yes! {total - washingP:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingP-total:f2}");
            }

        }
    }
}

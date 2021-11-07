using System;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double washingM = double.Parse(Console.ReadLine());
            double toyP = double.Parse(Console.ReadLine());
            double saved = 0;
            double toy = 0;
            double money = 10;
            for (int i = 1 ; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    saved += money;
                    saved -= 1;
                    money += 10;
                }
                else
                {
                    toy += 1;
                }
            }
            double total = saved + (toy * toyP);
            if (total>=washingM)
            {
                Console.WriteLine($"Yes! {total-washingM:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingM-total:f2}");
            }
        }
    }
}

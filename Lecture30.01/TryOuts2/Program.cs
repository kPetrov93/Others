using System;

namespace new11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toys = 0;
            double savedM = 0;
            int present = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedM += present;
                    savedM--;
                    present += 10;
                }
                else
                {
                    toys++;
                }
            }
            double total = (toys * toyPrice) + savedM;
            if (total >= washingPrice)
            {
                Console.WriteLine($"Yes! {total - washingPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingPrice-total:f2}");
            }
            
        }
    }
}

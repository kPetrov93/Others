using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double area = (lenght * wight * hight) * 0.001;
            double tPercent = percent * 0.01;
            double total = area - (area * tPercent);
            Console.WriteLine(total);
        }
    }
}

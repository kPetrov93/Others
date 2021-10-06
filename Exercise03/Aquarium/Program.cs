using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double size = lenght * width * hight;
            double litres = size * 0.001;
            double percentage = percent * 0.01;
            double total = litres * (1 - percentage);

            Console.WriteLine($"{total:f3}");

        }
    }
}

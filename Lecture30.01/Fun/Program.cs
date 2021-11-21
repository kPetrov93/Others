using System;

namespace fun
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double freeArea = a * b * c;

            while (true)
            {
                string n = Console.ReadLine();
                if (n == "Done")
                {
                    break;
                }
                int num = int.Parse(n);
                freeArea -= num;
                if (freeArea < 0)
                {
                    break;
                }


            }
            if (freeArea < 0)
            {
                double area = Math.Abs(freeArea);
                Console.WriteLine($"No more free space! You need {area} Cubic meters more.");

            }
            else
            {
                Console.WriteLine($"{freeArea} Cubic meters left.");    
            }        
        }
    }
}

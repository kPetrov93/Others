using System;

namespace Time15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalM = minutes + 15;

            if (totalM >= 60)
            {
                hours = hours + 1;
                totalM = totalM % 60;
                if (hours >= 24)
                {
                    hours = hours % 24;
                    totalM = totalM % 60;
                }
            }
            
            Console.WriteLine($"{hours}:{totalM:d2}");

       }
    }
}

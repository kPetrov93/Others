using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gen = Console.ReadLine();

            if (age >= 16)
            {
                if (gen == "m")
                {
                    Console.WriteLine("Mr.");
                }


                else if (gen == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
            else 
            {
                if (gen == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gen == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}

using System;

namespace dawd
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double fine = 0;
            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    fine += 150;
                }
                else if (site == "Instagram")
                {
                    fine += 100;
                }
                else if (site == "Reddit")
                {
                    fine += 50;
                }
                if (salary - fine <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary - fine > 0)
            {
                Console.WriteLine(salary-fine);
                
            }


        }
    }
}

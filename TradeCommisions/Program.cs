using System;

namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());
            double bonus = 0;
            bool isValid = true;
            if (city == "Sofia")
            {
                if (0 <= sale && sale <= 500)
                {
                    bonus = 0.05;
                }
                else if (500 < sale && sale <= 1000)
                {
                    bonus = 0.07;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    bonus = 0.08;
                }
                else if (sale > 10000)
                {
                    bonus = 0.12;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= sale && sale <= 500)
                {
                    bonus = 0.045;
                }
                else if (500 < sale && sale <= 1000)
                {
                    bonus = 0.075;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    bonus = 0.10;
                }
                else if (sale > 10000)
                {
                    bonus = 0.13;
                }
                else
                {
                    isValid = false;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sale && sale <= 500)
                {
                    bonus = 0.055;
                }
                else if (500 < sale && sale <= 1000)
                {
                    bonus = 0.08;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    bonus = 0.12;
                }
                else if (sale > 10000)
                {
                    bonus = 0.145;
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }
            if (isValid == false|| sale<0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{bonus*sale:f2}");
            }
        }
    }
}

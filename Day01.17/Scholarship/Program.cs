﻿using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)

        {
            double income = double.Parse(Console.ReadLine());

            double mark = double.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());

            double social = Math.Floor(wage * 0.35);
            double excellent = Math.Floor(mark * 25);

            if (income >= wage)
            {
                if (mark < 5.5)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (mark >= 5.5)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellent} BGN");
                }
            }
            else if (income <=wage)
            {
                if (mark >= 5.5)
                {
                    if (excellent >= social)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {excellent} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {social} BGN");
                    }
                }
                else if (mark > 4.5)
                {
                    Console.WriteLine($"You get a Social scholarship {social} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }

            }




        }
    }
}

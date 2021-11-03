using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rose = 5;
            double dahlias = 3.8;
            double tulips = 2.8;
            double narcis = 3;
            double gladiola = 2.5;
            double total = 0;
            if (flower == "Roses")
            {
                if (num > 80)
                {
                    rose = rose * 0.9;
                    total = num * rose;
                }
                else
                {
                    total = num * rose;  
                }
                
            }
            else if (flower == "Dahlias")
            {
                if (num > 90)
                {
                    dahlias = dahlias * 0.85;
                    total = num * dahlias;
                }
                else
                {
                    total =num * dahlias;
                }
            }
            else if (flower == "Tulips")
            {
                if (num > 80)
                {
                    tulips = tulips * 0.85;
                    total =num * tulips;
                }
                else
                {
                    total =num * tulips;
                }
            }
            else if (flower == "Narcissus")
            {
                if (num < 120)
                {
                    narcis = narcis * 1.15;
                    total = num * narcis;
                }
                else
                {
                    total =num * narcis;
                }
            }
            else if (flower=="Gladiolus")
            {
                if (num<80)
                {
                    gladiola = gladiola * 1.20;
                    total = num * gladiola;
                }
                else
                {
                    total =num * gladiola;
                }
            }
            if (total <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flower} and {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total-budget:f2} leva more.");
            }
        }
    }
}

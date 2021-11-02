using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            
            double apart = 0;
            double studio = 0;
            

            if (month == "May" || month == "October")
            {
                studio = 50;
                apart = 65;
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apart = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apart = 77;
            }

            if (nights > 7&& nights<14)
            {
                if (month == "May" || month == "October")
                {
                    studio = studio * 0.95;
                }
            }
            else if (nights > 14)
            {
                if (month == "May" || month == "October")
                {
                    studio = studio * 0.70;
                    apart = apart * 0.9;
                }
                else if (month == "June" || month == "September")
                {
                    studio = studio * 0.80;
                    apart = apart * 0.9;
                }
                else
                {
                    apart = apart * 0.9;
                }
            }
            
            Console.WriteLine($"Apartment: {apart*nights:f2} lv.");
            Console.WriteLine($"Studio: {studio*nights:f2} lv.");

        }
    }
}

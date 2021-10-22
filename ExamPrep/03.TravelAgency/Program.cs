using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string discount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double totalDays = days;
            bool isValid = false;
            bool moreThan = false;
            
            if (days > 7)
            {
                totalDays--;
               
            }
            if (days<=0)
            {
                moreThan = true;
            }
            double price = 0;
            double totalDiscount = 1;
            if (city == "Bansko" || city == "Borovets")
            {
                if (packet == "noEquipment")
                {
                    price = 80;
                    if (discount == "yes")
                    {
                        totalDiscount = 0.95;
                    }
                    else if (discount != "no")
                    {
                        isValid = true;
                    }

                }
                else if(packet=="withEquipment")
                {
                    price = 100;
                    if (discount == "yes")
                    {
                        totalDiscount = 0.90;
                    }
                    else if (discount != "no")
                    {
                        isValid = true;
                    }
                }
                else
                {
                    isValid = true;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (packet == "noBreakfast")
                {
                    price = 100;
                    if (discount == "yes")
                    {
                        totalDiscount = 0.93;
                    }
                    else if (discount != "no")
                    {
                        isValid = true;
                    }

                }
                else if(packet=="withBreakfast")
                {
                    price = 130;
                    if (discount == "yes")
                    {
                        totalDiscount = 0.88;
                    }
                    else if (discount!="no")
                    {
                        isValid = true;
                    }
                }
                else
                {
                    isValid = true;
                }
            }
            else
            {
                isValid = true;
            }
            
            double total = (totalDays * price) * totalDiscount;

            if (moreThan)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {total:f2}lv! Have a nice time!");
            }

        }
    }
}

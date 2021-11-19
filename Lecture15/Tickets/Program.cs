using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            int totalTickets = 0;
            double studentTickets = 0;
            double kidsTickets = 0;
            double standardTickets = 0;

            while (isTrue)
            {
                string name = Console.ReadLine();
                if (name == "Finish")
                {
                    isTrue = false;
                    break;
                }
                double chairs = double.Parse(Console.ReadLine());
                double takenChairs = 0;
                while (true)
                {
                double totalChairs = chairs;
                string input = Console.ReadLine();
                if (input == "End")
                    {
                        Console.WriteLine($"{name} - {(takenChairs / totalChairs) * 100:f2}% full.");
                        break;
                    }

                if (input == "Finish")
                    {
                        Console.WriteLine($"{name} - {(takenChairs / totalChairs) * 100:f2}% full.");
                        isTrue = false;
                        break;
                    }
                
                takenChairs++;
                if (input == "standard")
                {
                    standardTickets++;
                    totalTickets++;
                    
                }
                else if (input == "kid")
                {
                    kidsTickets++;
                    totalTickets++;
                    
                }
                else if (input == "student")
                {
                    studentTickets++;
                    totalTickets++;
                    
                }
                if (takenChairs >= totalChairs)
                    {
                        Console.WriteLine($"{name} - {(takenChairs / totalChairs) * 100:f2}% full.");
                        break;
                    }
                }
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTickets / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidsTickets / totalTickets) * 100:f2}% kids tickets.");
        }
    }
}

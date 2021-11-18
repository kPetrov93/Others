using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOver = true;
            double kidsT = 0;
            double totalKidsTickets = 0;
            double standardT = 0;
            double totalStandartTickets = 0;
            double studentT = 0;
            double totalStudentTickets = 0;
            double totalTickets = 0;
            double takenChairs = 0;

            while (isOver)
            {
                string film = Console.ReadLine();
                if (film == "Finish")
                {
                    isOver = false;
                    break;
                }
                string freeChairs = Console.ReadLine(); ;
                if (freeChairs=="Finish")
                {
                    isOver = false;
                    break;
                }
                double freeChairs1 = double.Parse(freeChairs);
                bool isTrue = true;
                bool finish = true;
                while (isTrue)
                {
                double taken = (takenChairs / freeChairs1) * 100.0;

                    string tickets = Console.ReadLine();
                    if (tickets == "End")
                    {
                        Console.WriteLine($"{film} - {taken:f2}% full.");
                        isTrue = false;
                        kidsT = 0;
                        standardT = 0;
                        studentT = 0;
                        takenChairs = 0;
                        continue;
                    }
                    if (tickets == "student")
                    {
                        totalTickets++;
                        takenChairs++;
                        totalStudentTickets++;
                        studentT++;
                    }
                    else if (tickets == "kid")
                    {
                        totalTickets++;
                        takenChairs++;
                        totalKidsTickets++;
                        kidsT++;
                    }
                    else if (tickets == "standard")
                    {
                        totalTickets++;
                        takenChairs++;
                        totalStandartTickets++;
                        standardT++;
                    }
                    if (tickets == "Finish")
                    {
                        Console.WriteLine($"{film} - {taken:f2}% full.");
                        isTrue = false;
                        finish = false;
                        isOver = false;
                        takenChairs = 0;
                        break;
                    }
                    if (takenChairs >= freeChairs1)
                    {
                        isTrue = false;
                        continue;
                    }
                }
                if (finish)
                {
                    continue;
                }
            }

            double kidPer = ( totalKidsTickets/totalTickets ) * 100.0;
            double standardPer = (totalStandartTickets / totalTickets) * 100.0;
            double studentPer = (totalStudentTickets / totalTickets) * 100.0;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPer:f2}% student tickets.");
            Console.WriteLine($"{standardPer:f2}% standard tickets.");
            Console.WriteLine($"{kidPer:f2}% kids tickets.");  
        }
    }
}

using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arivalH = int.Parse(Console.ReadLine());
            int arivalM = int.Parse(Console.ReadLine());

            examM += examH * 60;
            arivalM += arivalH * 60;
            int difference =arivalM-examM;
            int difference2 = examM - arivalM;

            if (arivalM > examM)
            {
                Console.WriteLine("Late");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{(arivalM-examM)/60}:{difference%60:d2} hours after the start");
                }
            }
            else if (arivalM <= examM && difference2<=30)
            {
                Console.WriteLine("On time");
                if (arivalM< examM)
                {
                    Console.WriteLine($"{examM - arivalM} minutes before the start");
                }
                
            }
            else
            {
                Console.WriteLine("Early");
                if (difference2>30 &&difference2<60)
                {
                    Console.WriteLine($"{examM - arivalM} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{(examM-arivalM) / 60}:{difference2 % 60:d2} hours before the start");
                }
            }        

        }
    }
}

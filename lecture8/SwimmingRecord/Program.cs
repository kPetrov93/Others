using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time1 = double.Parse(Console.ReadLine());

            double totalTimeItTakes = distance * time1;
            double slow = Math.Floor(distance / 15) ;
            double resistance = slow * 12.5;
            double totalT = totalTimeItTakes + resistance;

            if (totalT < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalT:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalT-record:f2} seconds slower.");
            }


        }
    }
}

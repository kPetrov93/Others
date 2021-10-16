using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double tpm = double.Parse(Console.ReadLine());

            double slow =Math.Floor (distance / 15);
            double drag = slow * 12.5;
            double time = (distance * tpm) + drag;
            if (time < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {time-record:f2} seconds slower.");
            }


        }
    }
}

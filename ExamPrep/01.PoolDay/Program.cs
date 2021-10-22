using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double bedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double entranceIncome = people * entranceFee;
            double bedIncome = (Math.Ceiling(people * 0.75)) * bedPrice;
            double umbrellaIncome = (Math.Ceiling(people * 0.50)) * umbrellaPrice;
            double total = entranceIncome + bedIncome + umbrellaIncome;

            Console.WriteLine($"{total:f2} lv.");

        }
    }
}

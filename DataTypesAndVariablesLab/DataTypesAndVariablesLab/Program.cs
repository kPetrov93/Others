using System;

namespace DataTypesAndVariablesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double volume = Math.PI * (r * r) * h;

                if (volume>biggestVolume)
                {
                    biggestKeg = name;
                    biggestVolume = volume;
                }
            }
            Console.WriteLine(biggestKeg);

        }
    }
}

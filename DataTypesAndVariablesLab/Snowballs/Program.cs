using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger value = 0;
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger total = BigInteger.Pow((snow / time), quality);

                if (total > value)
                {
                    value = total;
                    biggestSnow = snow;
                    biggestQuality = quality;
                    biggestTime = time;
                }
            }

            Console.WriteLine($"{biggestSnow} : {biggestTime} = {value} ({biggestQuality})");

        }
    }
}

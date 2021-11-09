using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double oddSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenSum = 0;
            
            for (int i = 0; i < n; i++)
            {
                 if(i%2!=0)
                {
                    double even = double.Parse(Console.ReadLine());
                    evenSum += even;
                    if (even >= evenMax)
                    {
                        evenMax = even;
                    }
                    if (even <= evenMin)
                    {
                        evenMin = even;
                    }
                }
                else
                {
                    double odd = double.Parse(Console.ReadLine());
                    oddSum += odd;

                    if (odd >= oddMax)
                    {
                        oddMax = odd;
                    }
                    if (odd <= oddMin)
                    {
                        oddMin = odd;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin ==double.MaxValue )
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}

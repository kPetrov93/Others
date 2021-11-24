using System;

namespace Lecture30._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           double even = 0;
            double odd = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int num1 = int.Parse(Console.ReadLine());
                   
                    even += num1;
                }
                else
                {
                    int num1 = int.Parse(Console.ReadLine());
                    ;
                    odd += num1;
                }
            }
            double diff = Math.Abs(even - odd);
            if (even == odd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}

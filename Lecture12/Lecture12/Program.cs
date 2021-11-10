using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    left += num;
                    left += num2;
                }
                else
                {
                    right += num;
                    right += num2;
                }
            }
            double total = Math.Abs(left - right);
            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {right}");
            }
            else
            {
                Console.WriteLine($"No, diff = {total}");
            }
        }
    }
}

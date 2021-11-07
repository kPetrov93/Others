using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            for (int i = 0; i < count; i++)
            {
                int leftN = int.Parse(Console.ReadLine());
                left += leftN;
            }
            for (int i = 0; i < count; i++)
            {
                int rightN = int.Parse(Console.ReadLine());
                right += rightN;
            }
            int all = Math.Abs(left - right);
            if (left==right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {all}");
            }
        }
    }
}

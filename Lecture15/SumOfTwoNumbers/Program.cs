using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());
            int count = 0;
            int num10 = 0;
            int num20 =0;
            bool isTrue = false;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    count++;
                    if (num1 + num2 == magicN)
                    {
                        num10 = num1;
                        num20 = num2;
                        isTrue = true;
                        break;
                    }

                }
                if (isTrue)
                {
                    break;
                }
            }
            if (isTrue)
            {
                Console.WriteLine($"Combination N:{count} ({num10} + {num20} = {magicN})");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicN}");
            }


        }
    }
}

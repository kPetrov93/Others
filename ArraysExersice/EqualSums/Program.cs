using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input.Length <= 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < input.Length ; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }
                for (int k = i + 1; k < input.Length; k++)
                {
                    rightSum += input[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

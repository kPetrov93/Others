using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var lastDig = num[0];

                for (int j = 0; j < num.Length - 1; j++)
                {
                    num[j] = num[j + 1];
                }

                num[num.Length - 1] = lastDig;
            }

            Console.WriteLine(string.Join(" ", num));
        }
    }
}

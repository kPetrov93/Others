using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j <input.Length; j++)
                {
                    if (input[i]+input[j]==n)
                    {
                        Console.WriteLine(input[i] + " " +input[j]);
                    }
                }
            }
        }
    }
}

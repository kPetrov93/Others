using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
       
            for (int i = 0; i < input.Length; i++)
            {
                bool isTrue = false;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        isTrue = true;
                    }
                    else
                    {
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.Write(input[input.Length-1]);

        }
    }
}

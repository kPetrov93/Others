using System;
using System.Linq;

namespace MaxSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxElements = 0;
            int currentElement = 1;
            int element = 0;

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    currentElement++;
                }
                else
                {
                    currentElement = 1;
                }
                if (currentElement>maxElements)
                {
                    maxElements = currentElement;
                    element = input[i];
                }
            }
            for (int i = 0; i < maxElements; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}

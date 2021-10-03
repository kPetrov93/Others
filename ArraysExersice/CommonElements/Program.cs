using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split().ToArray();
            string[] second = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (second[j]==first[i])
                    {
                        Console.Write(second[j] + " ");
                    }
                }
            }

        }
    }
}

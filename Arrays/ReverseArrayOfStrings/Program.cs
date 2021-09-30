using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split().ToArray();

            for (int i = 0; i <text.Length/2; i++)
            {
                var oldText = text[i];
                text[i] = text[text.Length - 1 - i];
                text[text.Length - 1 - i] = oldText;
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}

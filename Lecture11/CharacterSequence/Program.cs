using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int leng = input.Length;
            
            for (int i = 0; i < leng; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}

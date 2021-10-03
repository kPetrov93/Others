using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int bestDNA = 0;
            string DNA = "";
            int sum = 0;
            int bestPosition = 0;


            while (command != "Clone them!")
            {
                var input = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSum = input.Sum();
                int currentTotal = 1;
                int position = 0;
                for (int i = 0; i < n - 1; i++)
                {


                    if (input[i] == input[i + 1] && input[i] > 0)
                    {
                        currentTotal++;
                    }
                    else
                    {
                        currentTotal = 1;
                    }
                    if (currentTotal > bestDNA)
                    {
                        bestDNA = currentTotal;
                        DNA = command;
                    }
                    //if (input[i] > 0)
                    {
                        //currentSum++;
                    }
                    // if (currentSum > sum)
                    {
                        //sum = currentSum;
                    }
                    Console.WriteLine(currentSum);
                }






                // if (currentSum > sum)
                {
                    //    sum = currentSum;
                }
                command = Console.ReadLine();
            }
            // var dna = DNA.Split("!").Select(int.Parse).ToArray();
            //Console.WriteLine($"Best DNA sample {bestDNA} with sum: {sum}.");
            //Console.WriteLine(string.Join(" ",dna));

           
        }
    }
}

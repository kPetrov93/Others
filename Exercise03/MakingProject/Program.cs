using System;

namespace MakingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());

            int time = project * 3;

            Console.WriteLine($"The architect {name} will need {time} hours to complete {project} project/s.");


        }
    }
}

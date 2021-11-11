using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            double total= 0;
            int problems = 0;
            string last = "";
            int totalMarks = 0;
            int badMarksHeGot = 0;

            while (true)
            {
                string name = Console.ReadLine();
                if (name=="Enough")
                {
                    Console.WriteLine($"Average score: {total/totalMarks:f2}");
                    Console.WriteLine($"Number of problems: {problems}");
                    Console.WriteLine($"Last problem: {last}");
                    break;
                }
                double mark = double.Parse(Console.ReadLine());
                total += mark;
                last = name;
                problems++;
                totalMarks++;
                if (mark<=4)
                {
                    badMarksHeGot++;
                    if (badMarksHeGot>=badMarks)
                    {
                        Console.WriteLine($"You need a break, {badMarks} poor grades.");
                        break;
                    }
                }
            }
        }
    }
}

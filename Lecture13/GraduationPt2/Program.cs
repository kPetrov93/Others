using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double total = 0;
            int grade = 0;
            int rep = 0;

            while (grade<12)
            {
                double mark = double.Parse(Console.ReadLine());
                    grade++;
                if (mark>=4)
                {
                    total += mark;
                }
                else if(mark<4)
                {
                    rep++;
                    if (rep >= 2)
                    {
                        break;
                    }
                    continue;
                }
            }
            double average = total / 12;
            if (grade == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grade-1} grade");
            }
        }
    }
}

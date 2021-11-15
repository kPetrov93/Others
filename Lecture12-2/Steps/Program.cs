using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int stepsGoal = 10000;
            int total = 0;

            while (true)
            {
                string stepsN = Console.ReadLine();
                if (stepsN == "Going home")
                {
                    string stepsNew = Console.ReadLine();
                    int steps1 = int.Parse(stepsNew);
                    total += steps1;
                    break;
                }
                int steps = int.Parse(stepsN);
                
                total += steps;
                if (total >= stepsGoal)
                {
                    break;
                }
            }
            if (total>=stepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{total-stepsGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsGoal-total} more steps to reach goal.");
            }
        }
    }
}

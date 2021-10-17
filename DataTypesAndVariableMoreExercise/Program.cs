using System;

namespace DataTypesAndVariableMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            int timesL = 0;
            int timesR = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    left++;
                    timesL++;
                    if (timesR!=0)
                    {
                    timesR--;
                    
                    }
                    if (timesL>=2)
                    {
                        left += 10;
                    }

                }
                if (input == ")")
                {
                    right++;
                    timesR++;
                    if (timesL!=0)
                    {
                    timesL--;
                    
                    }
                    if (timesR>=2)
                    {
                        right += 30;
                    }
                }
            }

            if (left == right)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

            
        }
    }
}

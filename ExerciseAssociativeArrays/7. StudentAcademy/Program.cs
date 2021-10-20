using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!input.ContainsKey(name))
                {
                    input.Add(name, new List<double>());
                    
                }

                input[name].Add(grade);
                
            }

            foreach (var student in input.OrderByDescending(x=>x.Value.Average()))
            {
                if (student.Value.Average()>=4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}

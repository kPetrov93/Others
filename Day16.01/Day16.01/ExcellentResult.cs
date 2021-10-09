using System;

namespace Day16._01
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            if (mark>=5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}

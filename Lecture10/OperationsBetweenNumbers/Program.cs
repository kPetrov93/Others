using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double result = 0;

            if (oper == "+")
            {
                result = n1 + n2;
            }
            else if (oper == "-")
            {
                result = n1 - n2;
            }
            else if (oper == "*")
            {
                result = n1 * n2;
            }
            else if (oper == "/")
            {
                result = n1 / n2;
            }
            else if (oper == "%")
            {
                result = n1 % n2;
            }
            if (oper == "+" || oper == "-" || oper == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - odd");
                }
            }
            else if (oper == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else if (oper=="%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
        }
    }
}

using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    double banana = 2.50;
                    Console.WriteLine($"{banana * num:f2}");
                }
                else if (fruit == "apple")
                {
                    double apple = 1.20;
                    Console.WriteLine($"{apple * num:f2}");
                }
                else if (fruit == "orange")
                {
                    double orange = 0.85;
                    Console.WriteLine($"{orange * num:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double grapefruit = 1.45;
                    Console.WriteLine($"{grapefruit * num:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double kiwi = 2.70;
                    Console.WriteLine($"{kiwi * num:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double pineapple = 5.50;
                    Console.WriteLine($"{pineapple * num:f2}");
                }
                else if (fruit == "grapes")
                {
                    double grapes = 3.85;
                    Console.WriteLine($"{grapes * num:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    double banana = 2.70;
                    Console.WriteLine($"{banana * num:f2}");
                }
                else if (fruit == "apple")
                {
                    double apple = 1.25;
                    Console.WriteLine($"{apple * num:f2}");
                }
                else if (fruit == "orange")
                {
                    double orange = 0.90;
                    Console.WriteLine($"{orange * num:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double grapefruit = 1.60;
                    Console.WriteLine($"{grapefruit * num:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double kiwi = 3.00;
                    Console.WriteLine($"{kiwi * num:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double pineapple = 5.60;
                    Console.WriteLine($"{pineapple * num:f2}");
                }
                else if (fruit == "grapes")
                {
                    double grapes = 4.20;
                    Console.WriteLine($"{grapes * num:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            }
        }
    }


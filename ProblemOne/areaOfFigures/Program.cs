using System;

namespace areaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:f3}");
            }

            else if (figure== "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = side * side2;
                Console.WriteLine($"{area:f3}");
            }

            else if (figure == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side * Math.PI;
               
                Console.WriteLine($"{area:f3}");
            }

            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = (side * side2) / 2;
                Console.WriteLine($"{area:f3}");
            }



        }
    }
}

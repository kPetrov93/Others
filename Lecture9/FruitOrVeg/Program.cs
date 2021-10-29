using System;

namespace FruitOrVeg
{
    class Program
    {
        static void Main(string[] args)
        {
            string thing = Console.ReadLine();

            if (thing == "banana" || thing == "apple" || thing == "kiwi" || thing == "cherry" || thing == "lemon" || thing== "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (thing== "tomato"|| thing=="cucumber"|| thing=="pepper" || thing== "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

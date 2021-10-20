using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double[]> dict = new Dictionary<string, double[]>();

            while (input != "buy")
            {
                string[] sorted = input.Split().ToArray();
                string product = sorted[0];
                double price = double.Parse(sorted[1]);
                double quantity = double.Parse(sorted[2]);

                if (!dict.ContainsKey(product))
                {
                    dict.Add(product,new double[2]);
                }
                double priviousQty = dict[product][1];
                double[] priceQty = new double[] { price, quantity+priviousQty };
                dict[product]=priceQty;
                

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}

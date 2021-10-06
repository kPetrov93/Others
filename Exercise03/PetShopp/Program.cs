using System;


class Program
{
    static void Main()
    {
        int dogs = int.Parse(Console.ReadLine());
        int others = int.Parse(Console.ReadLine());

        double dogsFood = dogs * 2.50;
        int othersFood = others * 4;
        double total = dogsFood + othersFood;

        Console.WriteLine($"{total:f2} lv.");
    }
}
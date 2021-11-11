using System;

namespace Lecture12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int end = 0;

            while (true)
            {
                string searching = Console.ReadLine();
                if (book == searching)
                {
                    Console.WriteLine($"You checked {end} books and found it.");
                    break;
                }
                else if (searching == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {end} books.");
                    break;
                }
                
                end++;
            }

        }
    }
}

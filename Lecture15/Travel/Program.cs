using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                string destination = Console.ReadLine();
                bool end = true;
                if (destination=="End")
                {
                    end = false;
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                int total = 0;
                bool isTrue = true;

                while (isTrue)
                {
                    while (total < budget&&isTrue)
                    {
                        string input = Console.ReadLine();
                        if (input != "End" && input != "Greece" && input != "Spain" && input != "France" && input != "Portugal" && input != "Egypt")
                        {
                            int money = int.Parse(input);
                            total += money;
                            continue;

                        }
                        else if (input == "End")
                        {
                            isTrue = false;
                            end = false;
                            continue;
                        }
                        else
                        {

                            isTrue=false;
                        }
                    }
                    if (isTrue==false)
                    {
                        break;
                    }
                    total = 0;
                    Console.WriteLine($"Going to {destination}!");
                    isTrue = false;
                    continue;
                }

                if (end==false)
                {
                    break;
                }
            }

        }
    }
}

using System;

class Assignment3C2
{
    static void Main(string[] args)
    {
        int decisionValue = 0;
        try
        {
            Console.WriteLine("[Cretaceous Park Dialog]");
            Console.WriteLine("Oh no, the power has gone out at Cretaceous Park!");
            Console.WriteLine("1) What does that mean?");
            Console.WriteLine("2) No, I just turned the light off.");
            decisionValue = Convert.ToInt32(Console.ReadLine());
            if (decisionValue == 2)
            {
                Console.WriteLine("No, I just turned off the light");
                Console.WriteLine("\nOh Thank goodness!");
            }
            else if (decisionValue == 1)
            {
                Console.WriteLine("What does that mean?");
                Console.WriteLine("\nThe dinosaurs will get loose... again...");
                Console.WriteLine("1) Life finds a way...");
                Console.WriteLine("2) What do we do?");
                decisionValue = Convert.ToInt32(Console.ReadLine());
                if (decisionValue == 1)
                {
                    Console.WriteLine("That's not helpful right now!");
                }
                else
                {
                    Console.WriteLine("\nInvalid answer. Please try again");
                    return;
                }
                Console.WriteLine("\nWe will have to evacute the park");
            }
            else
            {
                Console.WriteLine("\nInvalid answer. Please try again");
            }
        } 
        catch (Exception ex)
        {
            Console.WriteLine("\nInvalid answer. Please try again.");
        }
        Console.WriteLine();
    }
}
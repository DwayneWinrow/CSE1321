using System;

public class Lab5B
{
    public static void Main(String[] args)
    {
        int testValue = 0;

        Console.Write("Enter an integer: ");
        testValue = Convert.ToInt16(Console.ReadLine());
        switch(testValue % 5)
        {
            case 0:
                if (testValue % 2 == 0)
                {
                    Console.WriteLine("This number is divisible by 2");
                }
                else
                {
                    Console.WriteLine("This number is divisible by 5");
                }
                break;
            default:
                switch (testValue % 3)
                {
                    case 0:
                        if (testValue % 2 == 0)
                        {
                            Console.WriteLine("This number is divisible by 2");
                        }
                        else
                        {
                            Console.WriteLine("This number is divisible by 3");
                        }
                        break;
                    default:
                        switch (testValue % 2)
                        {
                            case 0:
                                Console.WriteLine("This number is divisible by 2");
                                break;
                            default:
                                 Console.WriteLine("This number is undetermined");
                                break;
                        }
                        break;
                }
                break;
        }
        Console.WriteLine();
    }
}
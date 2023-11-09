using System;
public class Lab4C
{

    public static void Main(String[] args)
    {
        float inputValue;
        float outputValue;
        string invaluateValue = String.Empty;
        while (invaluateValue != "4")
        {
            Console.WriteLine("\nWelcome! ");
            Console.Write("Please input a number: ");
            inputValue = float.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat would you line to do? ");
            Console.WriteLine("0) Get the additive inverse of the number ");
            Console.WriteLine("1) Get the reciprocal of the number ");
            Console.WriteLine("2) Square the number ");
            Console.WriteLine("3) Cube the number ");
            Console.WriteLine("4) Exit the program ");
            Console.WriteLine();
            invaluateValue = Console.ReadLine();
            Console.WriteLine();
            switch (invaluateValue)
            {
                case "0":
                    Console.WriteLine($"The additive inverse of {inputValue.ToString("#.0")} is -{inputValue.ToString("#.0")}");
                    break;
                case "1":
                    outputValue = 1.0f / inputValue;
                    Console.WriteLine($"The reciprocal of {inputValue.ToString("#.0")} is {outputValue.ToString("#.0###")}");
                    break;
                case "2":
                    outputValue = inputValue * inputValue;
                    Console.WriteLine($"The square of {inputValue.ToString("#.0")} is {outputValue.ToString("#.0")}");
                    break;
                case "3":
                    outputValue = inputValue * inputValue * inputValue;
                    Console.WriteLine($"The cube of {inputValue.ToString("#.0")} is {outputValue.ToString("#.0")}");
                    break;
                case "4":
                    Console.WriteLine("Thank you, goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again!");
                    break;
            }
           
        }
    }
}
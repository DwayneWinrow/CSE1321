using System;

public class Lab11A
{
    public static void  Main(string[] args)
    {
        string responseTwo = "YES";
        while (responseTwo.Equals("YES"))
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0) Hello World");
            Console.WriteLine("1) Goodbye Moon");
            Console.WriteLine("2) Walking on Sunshine");
            Console.WriteLine();
            Console.Write("What would you like to do: ");
            string responseOne = Console.ReadLine().ToUpper();
            Console.WriteLine();
            switch (responseOne)
            {
                case "0":
                    Console.WriteLine("Hello!");
                    break;
                case "1":
                    Console.WriteLine("Ok, bye.");
                    break;
                case "2":
                    Console.WriteLine("WHOA!");
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.Write("Type YES to rerun. ");
           
            responseTwo = Console.ReadLine().ToUpper();
            Console.WriteLine();
        }
        Console.WriteLine("Program Ends");
        Console.WriteLine();
    }
}



using System;

public class Lab4B
{

    public static void Main(String[] args)
    {
        Console.Write("Enter a line of text: ");
        string DaysOfWeek = Console.ReadLine().ToUpper();
        switch(DaysOfWeek)
        {
            case "MONDAY":
            case "WEDNESDAY":
                Console.WriteLine("I have class today!"); 
                break;
            case "FRIDAY":
                Console.WriteLine("It’s Friday! Friday! Gotta get down on Friday!");
                break;
            default:
                Console.WriteLine("I should use this time to do my homework.");
                break;
        }
        Console.WriteLine();
    }
}
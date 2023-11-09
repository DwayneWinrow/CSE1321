using System;

public class Lab2C
{
    // Calculates fuel efficiency based on values entered by the user.
    public static void Main(String[] args)
    {
        decimal widthValue;
        decimal heightValue;
        Console.Write("Enter a width: ");
        widthValue = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter a height: ");
        heightValue = Convert.ToDecimal(Console.ReadLine());
        Console.Write("The area is "+widthValue*heightValue);
        Console.Write("\n");
        Console.Write("The perimeter is "+2*(widthValue + heightValue));
        Console.Write("\n");
        Console.Write("\n");
    }
}
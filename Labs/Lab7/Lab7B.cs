using System;

public class Lab7B
{
    public static void Main(String[] args)
    {
        Console.Write($"Please enter a value for the size: ");
        int intRightTriangle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"This is the requested {intRightTriangle}x{intRightTriangle} right-triangle:");

        for (int i = 0; i < intRightTriangle; i++)
        {
            for (int j = 0; j < i+1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
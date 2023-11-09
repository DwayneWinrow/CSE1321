using System;
public class Lab7C
{
    public static void Main(String[] args)
    {
        Console.Write($"Please enter a value for the size: ");
        int intRightTriangle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"This is the requested {intRightTriangle}x{intRightTriangle} right-triangle:");

        for (int i = 1; i <= intRightTriangle; i++)
        {
            for (int j = intRightTriangle; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
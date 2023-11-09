using System;

public class Lab7A
{
    public static void Main(String[] args)
    {
        Console.Write($"Please enter a value for the size: ");
        int intBox = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"This is the requested {intBox}x{intBox} box:");
        
        for (int i = 0; i < intBox; i++)
        {
            for (int j = 0; j < intBox; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


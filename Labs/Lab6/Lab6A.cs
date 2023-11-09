using System;

public class Lab6A
{
    public static void  Main(String[] args)
    {
        long getValue = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Please enter number {i}: ");
            long checkValue = Convert.ToInt32(Console.ReadLine());
            getValue = checkValue > getValue ? checkValue : getValue;
        }
        Console.WriteLine($"\nThe largest value was {getValue}\n");
    }
}


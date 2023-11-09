using System;

public class Lab2B
{
    public static void Main(String[] args)
    {
        // top part
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3 - i; j++)
            {
                Console.Write("_");
            }
            for (int j = 0; j < 1 + i; j++)
            {
                Console.Write("*");
                if (j != i)
                {
                    Console.Write("_");
                }
            }
            for (int j = 0; j < 3 - i; j++)
            { 
                Console.Write("_");
            }
            Console.WriteLine(""); 
        }
        // bottom part
        for (int i = 2; i >= 0; i--)
        {
            for (int j = 0; j < 3 - i; j++)
            {
                Console.Write("_");
            }
            for (int j = 0; j < 1 + i; j++)
            {
                Console.Write("*");
                if (j != i)
                {
                    Console.Write("_");
                }
            }
            for (int j = 0; j < 3 - i; j++)
            {
                Console.Write("_");
            }
            Console.WriteLine(""); 
        }
        Console.WriteLine("\n\n\n");
    }
}
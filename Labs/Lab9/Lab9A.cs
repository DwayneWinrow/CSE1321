using System;

public class Lab9A
{
    public static void  Main(String[] args)
    {
        var ArrayOne = new int[10];
        bool isFound = false;
        Console.WriteLine("Please enter 10 numbers: ");
        int count = 0;
        while(count<10)
        {
            Console.Write($"Integer {count+1}: ");
            ArrayOne[count] = Convert.ToInt32(Console.ReadLine());
            count++;
        }
        Console.WriteLine();
        Console.Write("What is the target number: ");
        int targerNumber = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < ArrayOne.Length; i++)
        {
            if (ArrayOne[i] == targerNumber)
            {
                isFound = true;
                break;
            }
        }
        Console.WriteLine();
        if (isFound)
        {
            Console.Write("The target is in the set.\n");
        } 
        else
        {
            Console.Write("The target is not in the set.\n");
        }
        Console.WriteLine();
    }
}


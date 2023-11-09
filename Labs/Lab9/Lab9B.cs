using System;

public class Lab9B
{
    public static void Main(String[] args)
    {
        var ArrayOne = new int[11];
        int intLow = 0;
        int intMid = 0;
        int intHigh = ArrayOne.Length - 1;
        bool isFound = false;
        string listNumber = string.Empty;
        Console.WriteLine("Please enter 11 numbers: ");
        int count = 0;
        while (count < 11)
        {
            Console.Write($"Integer {count + 1}: ");
            ArrayOne[count] = Convert.ToInt32(Console.ReadLine());
            count++;
        }
        Console.WriteLine();
        Console.Write("What is the target number: ");
        int targerNumber = Convert.ToInt32(Console.ReadLine());
        // Now we will sort the array.
        for(int i = 0; i < ArrayOne.Length - 1; i++)
        {
            for(int j = 0; j < ArrayOne.Length - i -1; j++)
            {
                if(ArrayOne[j] > ArrayOne[j+1])
                {
                    int temp = ArrayOne[j];
                    ArrayOne[j] = ArrayOne[j + 1];
                    ArrayOne[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < ArrayOne.Length; i++)
        {
            listNumber = listNumber +" " + ArrayOne[i];
        }
        
        Console.Write($"\nThe sorted set is:{listNumber}");

        Console.WriteLine();
        while (intHigh >= intLow)
        {
            Console.WriteLine($"Low is {intLow}\n");
            Console.WriteLine($"High is {intHigh}\n");
            intMid = (intLow + intHigh) / 2;
            Console.WriteLine($"Mid is {intMid}\n");
            Console.WriteLine("Searching\n");
            if (targerNumber < ArrayOne[intMid])
            {
                intHigh = intMid - 1;
            }
            else if (targerNumber == ArrayOne[intMid])
            {
                isFound = true;
                break;
            }
            else
            {
                intLow = intMid + 1;
            }
        }
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
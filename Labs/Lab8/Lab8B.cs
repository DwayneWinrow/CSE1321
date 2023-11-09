using System;

public class Lab8B
{
    public static void Main(String[] args)
    {
      
        Console.Write($"Please enter the number of rows: ");
        int new2DarrayRow = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Please enter the number of columns: ");
        int new2DarrayColumn = Convert.ToInt32(Console.ReadLine());
        int[,] new2Darray = new int[new2DarrayRow, new2DarrayColumn];
        Console.WriteLine($"\nI have {new2DarrayRow} rows and {new2DarrayColumn} columns. I need to fill-up {new2DarrayRow * new2DarrayColumn} spaces.");
        Console.WriteLine($"\nThe {new2DarrayRow}x{new2DarrayColumn} array:");
        int count = 0;

        for (int i = 0; i < new2DarrayRow; i++)
        {
            for (int j = 0; j < new2DarrayColumn; j++)
            {
                count++;
                new2Darray[i, j] = count;
            }
        }


        for (int i = 0; i < new2DarrayRow; i++)
        {
            for(int j = 0; j < new2DarrayColumn; j++)
            {
                Console.Write($"{new2Darray[i,j]}|");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
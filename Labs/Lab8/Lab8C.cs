using System;
public class Lab8C
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
        string flattened = String.Empty;
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
            for (int j = 0; j < new2DarrayColumn; j++)
            {
                Console.Write($"{new2Darray[i, j]}|");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nThe {new2DarrayRow}x{new2DarrayColumn} 2-D array flattened into a {new2DarrayRow * new2DarrayColumn} cell 1-D array: ");
        for(int i = 1;i <= count; i++)
        {
            Console.Write(i + "|");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
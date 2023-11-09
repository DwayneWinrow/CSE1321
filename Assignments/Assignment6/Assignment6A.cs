using System;

class Assignment6A
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Building Character]");
        Console.Write("Enter an array width: ");
        int arrayWidthValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an array height: ");
        int arrayHeightValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an initial value: ");
        float arrayInitialValue = Convert.ToSingle(Console.ReadLine());
        var array2D = new float[arrayHeightValue, arrayWidthValue];
        Console.Write($"Creating an array with {arrayHeightValue} row(s) and {arrayWidthValue} column(s) \n");
        Console.WriteLine();
        initializeArray(array2D, arrayInitialValue);
        printArray(array2D);
        Console.WriteLine("Making the first row negative ");
        updateRow(array2D);
        printArray(array2D);
        Console.Write("Enter a row index: ");
        int rowIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a column index: ");
        int columnIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a value: ");
        float valueToUpdated = Convert.ToSingle(Console.ReadLine());
        updateValueOne(array2D, rowIndex, columnIndex, valueToUpdated);
        printArray(array2D);
        Console.WriteLine("Alternating rows ");
        updateRowAlternating(array2D);
        printArray(array2D);
       
        bool canUpdate = false;
        while(!canUpdate)
        {
            Console.Write("Enter a row index: ");
            int rowIndex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a column index: ");
            int columnIndex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a length: ");
            int colLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value: ");
            float valueToUpdated2 = Convert.ToSingle(Console.ReadLine());
            canUpdate = updateValueOne(array2D, rowIndex2, columnIndex2, colLength, valueToUpdated2);
            Console.WriteLine();
            if (canUpdate)
            {
                printArray(array2D);
            } 
            else
            {
                Console.WriteLine("Invalid information! Try again. ");
              
            }
            Console.WriteLine();
        }
        Console.WriteLine("Finally done! ");
    }
    private static void initializeArray(float[,] arrayInitialValue, float initialValue)
    {
        for (int i = 0; i < arrayInitialValue.GetLength(0); i++)
        {
            for (int j = 0; j < arrayInitialValue.GetLength(1); j++)
            {
                arrayInitialValue[i, j] = initialValue;
            }
        }
    }
    private static void printArray(float[,] ourArray)
    {
        for (int i = 0; i < ourArray.GetLength(0); i++)
        {
            for (int j = 0; j < ourArray.GetLength(1); j++)
            {
                Console.Write(ourArray[i, j] + ", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void updateRow(float[,] ourArray)
    {
        int firstRow = 0;
        for (int i = 0; i < ourArray.GetLength(1); i++)
        {
            ourArray[firstRow, i] = -ourArray[firstRow, i];
        }
        Console.WriteLine();
    }
    private static void updateRowAlternating(float[,] ourArray)
    {
        for (int i = 0; i < ourArray.GetLength(0); i++)
        {
            for (int j = 0; j < ourArray.GetLength(1); j++)
            {
                ourArray[i, j] = i % 2 == 0 ? 12.78f : 87.21f;
            }
        }
        Console.WriteLine();
    }
    private static void updateValueOne(float[,] ourArray, int rowIndex, int columnIndex,
        float updateValue)
    {
        ourArray[rowIndex, columnIndex] = updateValue;
        Console.WriteLine();
    }
    private static bool updateValueOne(float[,] ourArray, int rowIndex, int columnIndex,
        int colLength, float updateValue)
    {
        if (columnIndex >= ourArray.GetLength(1) && rowIndex >= ourArray.GetLength(0) 
            || columnIndex+colLength> ourArray.GetLength(1))
            return false;
;
        for (int i = columnIndex; i < columnIndex + colLength; i++)//column
        {
            ourArray[rowIndex, i] = updateValue;
        }
        return true;
    }
}

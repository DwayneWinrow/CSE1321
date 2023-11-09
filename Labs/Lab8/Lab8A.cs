using System;

public class Lab8A
{
    public static void  Main(String[] args)
    {
        var ArrayOne = new int[5];
        var ArrayTwo = new int[5];
        string requestMessage = "Please enter 5 integers for the first array: ";
        for (int j = 0; j < 2; j++)
        {
            if (j > 0)
                requestMessage = requestMessage.Replace("first", "second");

            Console.WriteLine(requestMessage);
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Integer {i + 1}: ");
                if (j == 0)
                {
                    ArrayOne[i] = Convert.ToInt32(Console.ReadLine());
                } 
                else
                {
                    ArrayTwo[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"The resulting sums are {ArrayOne[0] + ArrayTwo[0]}|" +
            $"{ArrayOne[1] + ArrayTwo[1]}|" +
            $"{ArrayOne[2] + ArrayTwo[2]}|" +
            $"{ArrayOne[3] + ArrayTwo[3]}|" +
            $"{ArrayOne[4] + ArrayTwo[4]}");
        Console.WriteLine();
    }
}


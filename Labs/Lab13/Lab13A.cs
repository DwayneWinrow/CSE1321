using System;

public class Lab13A
{
    public static void  Main(String[] args)
    {
        long getValue = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Please enter number {i + 1}: ");
            long checkValue = Convert.ToInt32(Console.ReadLine());
            getValue = checkValue > getValue ? getValue = checkValue : getValue;
        }
        Console.WriteLine($"\nThe largest value was {getValue}\n");

        //int x = 0;
        //x = 9 % 5 * 3 + 6;
        ////int x = 9 % 4;// / 2f;
        //// int y = 8;
        ////while(x<100)
        ////{
        ////    x *= 2;
        ////    Console.WriteLine($"\n x=>  {x}\n");
        ////}
        //Console.WriteLine($"\n x=>  {x}\n");

    }
}


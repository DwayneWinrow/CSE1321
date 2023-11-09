using System;

public class Lab10A
{
    public static void  Main(String[] args)
    {
        Console.Write("Enter Number 1: ");
        int firstParm = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number 2: ");
        int SecondParm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Max is {getMaximum(firstParm,SecondParm)}");
        Console.WriteLine($"Min is {getMinimum(firstParm,SecondParm)}");
        Console.WriteLine($"Average is {getAverage(firstParm,SecondParm):0.#}\n");

    }
    private static int getMaximum(int firstParm, int secondParm)
    {
        return firstParm> secondParm ? firstParm : secondParm;
    }
    private static int getMinimum(int firstParm, int secondParm)
    {
        return firstParm < secondParm ? firstParm : secondParm;
    }
    private static Decimal getAverage(int minValue, int maxValue)
    {
        return Convert.ToDecimal((minValue + maxValue) / 2.0);
    }
}


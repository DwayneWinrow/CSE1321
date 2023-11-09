using System;
public class Lab5C
{

    public static void Main(String[] args)
    {
        int XValue = 0; 
        int YValue = 0;

        Console.Write("Enter x: ");
        XValue = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter y: ");
        YValue = Convert.ToInt16(Console.ReadLine());

        if (XValue == 0 && YValue == 0)
        {
            Console.WriteLine("This point is the origin.\n");
        }
        else if (XValue == 0 && YValue > 0)
        {
            Console.WriteLine("This point is on the y axis.\n");
        }
        else if (XValue < 0 && YValue == 0)
        {
            Console.WriteLine("This point is on the x axis.\n");
        }
        else if (XValue > 0 && YValue > 0)
        {
            Console.WriteLine("This point is in the first quadrant.\n");
        }
        else if (XValue < 0 && YValue > 0)
        {
            Console.WriteLine("This point is in the second quadrant.\n");
        }
        else if (XValue < 0 && YValue < 0)
        {
            Console.WriteLine("This point is in the third quadrant.\n");
        }
        else if (XValue > 0 && YValue < 0)
        {
            Console.WriteLine("This point is in the fourth quadrant.\n");
        }
    }
}
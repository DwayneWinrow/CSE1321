using System;

public class Lab10B
{
    public static void Main(String[] args)
    {
        string AnotherWidthHeight = "Y";
        while (AnotherWidthHeight.ToUpper().Trim() == "Y")
        {
            Console.Write("Enter width: ");
            double widthValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double heightValue = Convert.ToDouble(Console.ReadLine());
          
            if (isValid(widthValue, heightValue))
            {
                Console.WriteLine("This is a valid rectangle.");
                Console.WriteLine($"The area is: {area(widthValue, heightValue):0.#}");
                Console.WriteLine($"The perimeter is: {perimeter(widthValue, heightValue):0.#}");
            } 
            else
            {
                Console.WriteLine("This is an invalid rectangle.");
            }
            Console.WriteLine();
            Console.Write($"Do you want to enter another width and height (Y/N)? : ");
            AnotherWidthHeight = Console.ReadLine();
            Console.WriteLine();
        }
        Console.WriteLine("Program Ends\n");
    }
    private static bool isValid(double width, double height) 
    {
        return perimeter(width, height) > 30.0;
    }
    private static double area(double width, double height)
    {
        return width * height;
    }
    private static double perimeter(double width, double height)
    {
        return 2 * (width + height);
    }
}
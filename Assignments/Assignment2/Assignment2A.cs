using System;

class Assignment2A
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Octagon Calculator]");
        Console.Write("Enter the length of one side: ");
        double octagonSide = Convert.ToDouble(Console.ReadLine());
        double octagonPerimeter = octagonSide * 8;
        double octagonArea = 2 * (1 + Math.Sqrt(2)) * Math.Pow(octagonSide, 2);
        Console.WriteLine($"Octagon Perimeter = {octagonPerimeter}");
        Console.WriteLine($"Octagon Area = {octagonArea.ToString("0.####")}\n");

        Console.WriteLine("[Cylinder Calculator]");
        Console.Write("Enter the radius: ");
        double cylinderRadius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height: ");
        double cylinderHeight = Convert.ToDouble(Console.ReadLine());
        double cylinderArea = (2 * Math.PI * cylinderRadius * cylinderHeight) + (2 * Math.PI * Math.Pow(cylinderRadius, 2));
        double cylinderPerimeter = (4 * cylinderRadius) + (2 * cylinderHeight);
        Console.WriteLine($"Cylinder Perimeter = {cylinderPerimeter.ToString("0.####")}");
        Console.WriteLine($"Cylinder Area = {cylinderArea.ToString("0.####")}");
    }
}
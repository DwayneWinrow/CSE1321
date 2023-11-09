using System;

class Assignment2C
{
    static void Main(string[] args)
    {
        Console.Write("X coordinate (bottom-left corner): ");
        int xCoordinate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y coordinate (bottom-right corner): ");
        int yCoordinate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hit box width: ");
        int hitBoxWidth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hit box height: ");
        int hitBoxHeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sprite Hit Box Coordinates");
        Console.WriteLine($"Bottom-Left: {xCoordinate}, {yCoordinate}");
        Console.WriteLine($"Top-Left: {xCoordinate}, {yCoordinate + hitBoxHeight}");
        Console.WriteLine($"Bottom-Right: {xCoordinate + hitBoxWidth}, {yCoordinate}");
        Console.WriteLine($"Top-Right: {xCoordinate + hitBoxWidth}, {yCoordinate + hitBoxHeight}\n");

    }
}
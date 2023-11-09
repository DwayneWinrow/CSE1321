using System;

class Assignment1A
{
    static void Main(string[] args)
    {
        int redValue;
        int greenValue;
        int blueValue;
        float brightenPercentage = 0.0f;

        Console.Write("Enter a red value (0-255): ");
        redValue = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter a green value (0-255): ");
        greenValue = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter a blue value (0-255): ");
        blueValue = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter a percentage to brighten color from 0.0 to 1.0: ");
        brightenPercentage = Convert.ToSingle(Console.ReadLine());

        float invertedRed = 255-redValue;
        float invertedGreen = 255-greenValue;
        float invertedBlue = 255-blueValue;

        float percentOutRed = invertedRed * brightenPercentage + redValue;
        float percentOutGreen = invertedGreen * brightenPercentage + greenValue;
        float percentOutBlue = invertedBlue * brightenPercentage + blueValue;
        brightenPercentage = brightenPercentage * 100;
        Console.Write($"\nA {brightenPercentage.ToString("0.0")}% brighter tint of RGB ({redValue},{greenValue},{blueValue}) is \nRBG ({percentOutRed},{percentOutGreen},{percentOutBlue}).\n\n");

    }
}
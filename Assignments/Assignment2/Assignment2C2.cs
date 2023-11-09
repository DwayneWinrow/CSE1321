using System;

class Assignment2C2
{
    static void Main(string[] args)
    {
        const float EARTH_TO_MOON_IN_METERS = 384600000f;
        const float LENGTH_OF_ANIMAL_CRACKERS_IN_METER = .025f;
        Console.WriteLine("[Distance Calculator]");
        Console.Write("How many meters? ");
        float inputValue = float.Parse(Console.ReadLine());
        Console.WriteLine();
        float outputValue1 = inputValue /EARTH_TO_MOON_IN_METERS;
        float outputValue2 = inputValue /LENGTH_OF_ANIMAL_CRACKERS_IN_METER;
        Console.WriteLine($"{inputValue.ToString("0.#")} meter(s) is...");
        Console.WriteLine($"...{outputValue1.ToString("0.00000000##")} distance from the Moon");
        Console.WriteLine($"...{outputValue2.ToString("0")} Animal Crackers long");
        Console.WriteLine();
    }
}
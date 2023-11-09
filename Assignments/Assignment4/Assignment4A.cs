using System;

class Assignment4A
{
    static void Main(string[] args)
    {
        int time = 0;
        double distance = 0;
        float feetPerSecond;

        Console.WriteLine("[Stopping Time]");
        Console.Write("How fast are you going (miles/hour)? ");
        int theSpeed = Convert.ToInt32(Console.ReadLine());
        Console.Write("How quickly can you decelerate (miles)? ");
        int theDeceleration = Convert.ToInt32(Console.ReadLine());
        Console.Write("How often do you want to see updates (in seconds)? ");
        int theIntervalTime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nYou are going 5 MPH when you slam on the brakes!");

        while (theSpeed > 0)
        {
            feetPerSecond = theSpeed * 1.4667f; //<= 5280 divided by 3600
            distance += feetPerSecond;
            theSpeed -= theDeceleration;
            time++;

            if (time % theIntervalTime == 0)
            {
                Console.WriteLine($"At {time} seconds, you have traveled {distance.ToString("0.0000")} feet and are now moving at {theSpeed} MPH.");
            }
        }
        Console.WriteLine($"\nYou took {time} seconds to stop and traveled {distance.ToString("0.0000")} feet during that time!");
    }
}
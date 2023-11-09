using System;

class Assignment2B
{
    static void Main(string[] args)
    {
        const int SECONDS = 60;
        const int HOURS = 60 * SECONDS;
        Console.Write("Time in seconds: ");
        int TimeInSeconds = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Converting... ");
        int remainingSeconds = TimeInSeconds % SECONDS;
        int remainingMinutes = ((TimeInSeconds - remainingSeconds) % HOURS) / SECONDS;
        int remainingHours = TimeInSeconds / HOURS;
        Console.WriteLine($"{TimeInSeconds} seconds == {remainingHours} hour(s), " +
            $"{remainingMinutes} minute(s), and {remainingSeconds} second(s) ");
    }
}
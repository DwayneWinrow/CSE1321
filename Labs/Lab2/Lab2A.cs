using System;

public class Lab2A
{
    // Prints two lines of output representing a rocket countdown.
    public static void Main(String[] args)
    {
        String firstName;
        String secondName;
        String verbValue;
        String adverbValue;
        Console.Write("Enter a name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter another name: ");
        secondName = Console.ReadLine();
        Console.Write("Enter a verb: ");
        verbValue = Console.ReadLine();
        Console.Write("Enter an adverb: ");
        adverbValue = Console.ReadLine();
        Console.Write($"Once upon a time, there was a person named {firstName} who had a child named\n" +
            $"{secondName}. This child would {verbValue} {adverbValue} while singing to strangers.\n\n");

    }
}


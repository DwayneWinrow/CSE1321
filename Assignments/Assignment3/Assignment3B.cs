using System;

class Assignment3B
{
    static void Main(string[] args)
    {
        int numberOfContinents = 7;
        int howManyContinents = 0;
        
        Console.WriteLine("[World Traveler checklist]");
        
        for(int i = 1; i <= numberOfContinents; i++)
        {
            Console.Write($"{QuestionText(i)} ");
            char yesNo = Convert.ToChar(Console.ReadLine());
            if (yesNo == 'Y')
                howManyContinents++;
        }
        Console.WriteLine($"\nYou have visited {howManyContinents} continents: {ResponseMessage(howManyContinents)}\n");

    }
    private static string QuestionText(int QuestionNumber)
    {
        switch (QuestionNumber)
        {
            case 1:
                return "Have you been to Africa?";
            case 2:
                return "Have you been to Antarctica?";
            case 3:
                return "Have you been to Asia ?";
            case 4:
                return "Have you been to Australia?";
            case 5:
                return "Have you been to Europe?";
            case 6:
                return "Have you been to North America?";
            case 7:
                return "Have you been to South America?";
            default:
                return "Invalid continent question.";
        }
    }
    private static string ResponseMessage(int howManyContinents)
    {
        switch (howManyContinents)
        {
            case 0:
                return "How is that possible? Are you living in space?";
            case 1:
                return "That's a good start. Time to explore the world.";
            case 2:
            case 3:
                return "You've just started your journey to see the world.";
            case 4:
            case 5:
                return "You're an experienced traveler now.";
            case 6:
                return "Wow, you've been almost everywhere!";
            case 7:
                return "You're a true world traveler!";
            default:
                return "Invalid continent count.";
        }
    }
}
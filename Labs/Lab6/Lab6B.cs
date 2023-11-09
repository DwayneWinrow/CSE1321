using System;

public class Lab6B
{
    public static void Main(String[] args)
    {
        int iCountGuess = 0;
        int AIGuess = 0;

        Random random = new Random();
        Console.Write($"Enter a number between 1 and 1000: ");
        int userInput = Convert.ToInt16(Console.ReadLine());
        while (AIGuess != userInput)
        {
            AIGuess = random.Next(1000);
            Console.WriteLine($"My guess was {AIGuess}");
            if (AIGuess == userInput)
            {
                Console.WriteLine($"I guessed the number was {AIGuess} and it only took me {iCountGuess} guesses\n");
            }
            else
            {
                iCountGuess++;
            }
        }
    }
}
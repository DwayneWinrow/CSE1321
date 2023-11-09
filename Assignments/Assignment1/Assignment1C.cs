using System;

class Assignment1C
{
    static void Main(string[] args)
    {
        Console.Write("[XKCD Passphrase Generator]\n");

        Console.Write("Enter your third favorite animal: ");
        string animal = Console.ReadLine();

        Console.Write("Enter the subtotal from your last take-out meal: ");
        double subTotal = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter a whole number less than |32767|: ");
        short wholeNumber = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter a single letter: ");
        char singleLetter = Convert.ToChar(Console.ReadLine());

        string concatenation = $"{animal} {subTotal} {wholeNumber} {singleLetter}";
        string concatenation1 = $"{singleLetter} {wholeNumber} {animal} {subTotal} ";
        string concatenation2 = $"{subTotal} {singleLetter} {animal} {wholeNumber}";
        string concatenation3 = $"{wholeNumber} {animal} {singleLetter} {subTotal}";
        Console.Write($"\nYour passphrase is: {concatenation}\n");

        Console.Write($"Other variations are: \n");
        Console.Write($"{concatenation1}\n{concatenation2}\n{concatenation3}\n");
    }
}
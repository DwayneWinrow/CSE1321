using System;

public class Lab11B
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a password: ");
        string passwordCheck = Console.ReadLine();
        if (passwordCheck.Length >= 8 && checkForUpper(passwordCheck) && checkForNumber(passwordCheck))
        {
            Console.WriteLine("Valid password");
        } 
        else
        {
            Console.WriteLine("Invalid password");
        }
        Console.WriteLine();
        Console.WriteLine("Program Ends");
        Console.WriteLine(); 
    }
    public static bool checkForUpper(string passwordToCheck)
    {
        char[] characters = passwordToCheck.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsUpper(characters[i]))
            {
                return true;
            }
        }
        return false;
    }
    public static bool checkForNumber(string passwordToCheck)
    {
        char[] characters = passwordToCheck.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsNumber(characters[i]))
            {
                return true;
            }
        }
        return false;
    }
}
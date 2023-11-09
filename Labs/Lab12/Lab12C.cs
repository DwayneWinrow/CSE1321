using System;
public class Lab12C
{
    public static void Main(String[] args)
    {
        int balanceValue = 1000;
        int decisionValue = 0;
        int addValue = 0;
        string returnToMainMenu = "Y";
        Console.WriteLine($"Welcome! ");
        Console.WriteLine($"You have $1000 in your account. \n");

        while (returnToMainMenu.ToUpper() == "Y")
        {
            Console.WriteLine($"\nMenu");
            Console.WriteLine($"0 - Make a deposit");
            Console.WriteLine($"1 - Make a withdrawal");
            Console.WriteLine($"2 - Display account value\n");
            Console.Write($"Please make a selection: ");
            decisionValue = Convert.ToInt16(Console.ReadLine());
            switch (decisionValue)
            {
                case 0:
                    Console.Write($"How much would you like to deposit?: ");
                    addValue = Convert.ToInt16(Console.ReadLine());
                    balanceValue = balanceValue + addValue;
                    Console.WriteLine($"Your current balance is {balanceValue} ");
                    break;
                case 1:
                    Console.Write($"How much would you like to withdraw?: ");
                    addValue = Convert.ToInt16(Console.ReadLine());
                    balanceValue = balanceValue - addValue;
                    Console.WriteLine($"Your current balance is {balanceValue} ");
                    break;
                case 2:
                    Console.WriteLine($"Your current balance is {balanceValue} ");
                    break;
                default:
                    Console.WriteLine($"Invalid entry, please try again.");
                    break;
            }
            Console.Write($"Would you like to return to the main menu (Y/N)? : ");
            returnToMainMenu = Console.ReadLine();
        }
        Console.WriteLine($"\nThank you for banking with us.\n");
    }
}
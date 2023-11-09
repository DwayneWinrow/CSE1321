using System;

public class Lab3C
{
    public static void Main(String[] args)
    {
        const int QUARTER = 25;
        const int DIME = 10;
        const int NICKEL = 5;
        const int PENNIES = 1;
        const int ONE_HUNDRED_CENTS_EQUAL_ONE_DOLLAR = 100;
        int totalQuarters;
        int totalDimes;
        int totalNickels;
        int totalPennies;
        int totalCentsAmount = 0;
        int dollarAmount = 0;
        int centsAmount = 0;
        Console.Write("Enter the number of quarters: ");
        totalQuarters = Convert.ToInt16(Console.ReadLine());
        totalCentsAmount += (totalQuarters * QUARTER);
        Console.Write("Enter the number of dimes: ");
        totalDimes = Convert.ToInt16(Console.ReadLine());
        totalCentsAmount += (totalDimes * DIME);
        Console.Write("Enter the number of nickels: ");
        totalNickels = Convert.ToInt16(Console.ReadLine());
        totalCentsAmount += (totalNickels * NICKEL);

        Console.Write("Enter the number of pennies: ");
        totalPennies = Convert.ToInt16(Console.ReadLine());
        totalCentsAmount += (totalPennies * PENNIES);
        dollarAmount = totalCentsAmount / ONE_HUNDRED_CENTS_EQUAL_ONE_DOLLAR;
        centsAmount = totalCentsAmount % ONE_HUNDRED_CENTS_EQUAL_ONE_DOLLAR;
        Console.WriteLine();
        Console.WriteLine($"You entered {totalQuarters} quarters.");
        Console.WriteLine($"You entered {totalDimes} dimes.");
        Console.WriteLine($"You entered {totalNickels} nickels.");
        Console.WriteLine($"You entered {totalPennies} pennies.");
        Console.WriteLine();
        Console.WriteLine($"Your total is {dollarAmount} dollars and {centsAmount} cents.");

    }
}
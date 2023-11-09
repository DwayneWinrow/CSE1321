using System;

public class Lab3A
{
    public static void Main(String[] args)
    {
        const int MONTHS = 12;
        const int ONE_HUNDRED = 100;
        Console.Write("Amount owed: $");
        decimal amountOwedValue = Convert.ToDecimal(Console.ReadLine());
        Console.Write("APR: ");
        decimal aprValue = Convert.ToDecimal(Console.ReadLine());
        decimal minimumPayment = amountOwedValue * aprValue / MONTHS / ONE_HUNDRED;
        decimal monthlyPercentageRate = aprValue / MONTHS;
        Console.Write($"Monthly percentage rate: {monthlyPercentageRate.ToString("#,##0.000")}\n");
        Console.Write($"Minimum payment: ${minimumPayment.ToString("#,##0.00")}\n\n");
    }
}


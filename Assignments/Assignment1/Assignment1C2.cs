using System;

class Assignment1C2
{
    static void Main(string[] args)
    {
        int dayValue;
        int monthValue;
        string monthValueString;
        int yearValue;
        Console.Write("Enter the day (number): ");
        dayValue = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the month (number): ");
        monthValue = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the year (String): ");
        monthValueString = Console.ReadLine();
        Console.Write("Enter the year (number): ");
        yearValue = Convert.ToInt16(Console.ReadLine());
        Console.Write("Here are some ways to represent the date:");
        Console.Write("\n");
        Console.Write(monthValue+"/"+dayValue+"/"+yearValue);
        Console.Write("\n");
        Console.Write(yearValue + "/" + dayValue + "/" + monthValue);
        Console.Write("\n");
        Console.Write(dayValue + "/" + monthValue + "/" + yearValue);
        Console.Write("\n");
        Console.Write(monthValueString + " " + dayValue + "," + yearValue);
        Console.Write("\n");
        Console.Write(dayValue + " " + monthValueString + " " + yearValue);
        Console.Write("\n");
    }
}
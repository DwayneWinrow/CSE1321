
using System;
public class Lab3B
{
    public static void Main(String[] args)
    {
        Console.Write("Course 1 hours: ");
        float totalHour1 = (float)Convert.ToDecimal(Console.ReadLine());
        Console.Write("Grade for course 1: ");
        float totalPoint1 = (float)Convert.ToDecimal(Console.ReadLine());
        float qualityPoint1 = totalHour1 * totalPoint1;

        Console.Write("Course 2 hours: ");
        float totalHour2 = (float)Convert.ToDecimal(Console.ReadLine());
        Console.Write("Grade for course 2: ");
        float totalPoint2 = (float)Convert.ToDecimal(Console.ReadLine());
        float qualityPoint2 = totalHour2 * totalPoint2;

        Console.Write("Course 3 hours: ");
        float totalHour3 = (float)Convert.ToDecimal(Console.ReadLine());
        Console.Write("Grade for course 3: ");
        float totalPoint3 = (float)Convert.ToDecimal(Console.ReadLine());
        float qualityPoint3 = totalHour3 * totalPoint3;

        Console.Write("Course 4 hours: ");
        float totalHour4 = (float)Convert.ToDecimal(Console.ReadLine());
        Console.Write("Grade for course 4: ");
        float totalPoint4 = (float)Convert.ToDecimal(Console.ReadLine());
        float qualityPoint4 = totalHour4 * totalPoint4;
        float grandTotalQualityPoints = qualityPoint1 + qualityPoint2 + qualityPoint3 + qualityPoint4;
        float grandTotalHours = totalHour1 + totalHour2 + totalHour3 + totalHour4;
        float grandTotalQualityPointsByGrandTotalHours = grandTotalQualityPoints / grandTotalHours;

        Console.WriteLine($"Total hours is: {grandTotalHours}");
        Console.WriteLine($"Total quality points is: {grandTotalQualityPoints}");
        Console.WriteLine($"Your GPA for this semester is {grandTotalQualityPointsByGrandTotalHours.ToString("0.######")}");

    }
}
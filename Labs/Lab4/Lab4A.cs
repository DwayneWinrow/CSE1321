using System;

public class Lab4A
{

//C-
//74 - 76
//D+
//71 - 73
//D
//68 -70
//D-
//65 - 67
//F
//0 - 64
    public static void Main(String[] args)
    {
        int gradeValue;
        float gradeValueTemp;
        Console.Write("Enter the score of your exam: ");
        gradeValueTemp = (float)Convert.ToDecimal(Console.ReadLine());
        gradeValue = Convert.ToInt16(gradeValueTemp);
        string letterGradeValue =string.Empty;
        if (gradeValue >= 98 && gradeValue <= 100)
        {
            letterGradeValue = "A+";
        }
        else if (gradeValue >= 95 && gradeValue < 98)
        {
            letterGradeValue = "A";
        }
        else if(gradeValue >= 92 && gradeValue < 95)
        {
            letterGradeValue = "A-";
        }
        else if (gradeValue >= 89 && gradeValue < 92)
        {
            letterGradeValue = "B+";
        }
        else if (gradeValue >= 86 && gradeValue < 89)
        {
            letterGradeValue = "B";
        }
        else if (gradeValue >= 83 && gradeValue < 86)
        {
            letterGradeValue = "B-";
        }
        else if (gradeValue >= 80 && gradeValue < 83)
        {
            letterGradeValue = "C+";
        }
        else if (gradeValue >= 77 && gradeValue < 80)
        {
            letterGradeValue = "C";
        }
        else if (gradeValue >= 74 && gradeValue < 77)
        {
            letterGradeValue = "C-";
        }
        else if (gradeValue >= 71 && gradeValue < 74)
        {
            letterGradeValue = "D+";
        }
        else if (gradeValue >= 68 && gradeValue < 71)
        {
            letterGradeValue = "D";
        }
        else if (gradeValue >= 65 && gradeValue < 68)
        {
            letterGradeValue = "D-";
        }
        else
        {
            letterGradeValue = "F";
        }
        Console.WriteLine($"Letter grade is: {letterGradeValue}");
        Console.WriteLine();
    }
}


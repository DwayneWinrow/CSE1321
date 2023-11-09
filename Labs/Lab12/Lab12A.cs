using System;

public class Lab12A
{
    public static void  Main(String[] args)
    {
       
        Console.WriteLine($"You are about to create a chair.");
        Console.Write($"How many legs does your chair have: ");
        int numOfLegs = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Is your chair rolling (true/false): ");
        bool isRolling = Convert.ToBoolean(Console.ReadLine());
        Console.Write($"What is your chair made of: ");
        string theMaterial = Console.ReadLine();
        Chair chair = new Chair(numOfLegs,isRolling,theMaterial);
        Console.WriteLine();
        PrintMessage(chair);
        Console.WriteLine($"This program is going to change that.");
        Console.WriteLine();
        //change attributes
        chair.numOfLegs = 4;
        chair.rolling = false;
        chair.material = "wood";
        PrintMessage(chair);

    }
    public static void PrintMessage(Chair chair)
    {
        string isRolling = chair.rolling ? "rolling" : "not rolling";
        Console.WriteLine($"Your chair has {chair.numOfLegs} legs, is {isRolling}, and is made of {chair.material}.");
        Console.WriteLine();
    }
}
public class Chair
{
    public Chair(int numberOfLegs, bool isRolling, string theMaterial) 
    { 
        numOfLegs = numberOfLegs;
        rolling = isRolling;
        material = theMaterial;
    }
    public int numOfLegs { get; set; }
    public bool rolling { get; set; }   
    public string material { get; set; }
}


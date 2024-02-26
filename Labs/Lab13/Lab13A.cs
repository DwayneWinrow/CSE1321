using System;

public class Lab13A
{
    public static void Main(String[] args)
    {
        BuildingBlueprint buildingOne = new BuildingBlueprint();
        int secondStoriesforBuilding = 30;
        int secondApartmentsforBuilding = 30;
        float secondOccupanyforBuilding = .75f;
        BuildingBlueprint buildingTwo = 
            new BuildingBlueprint(secondStoriesforBuilding, secondApartmentsforBuilding, secondOccupanyforBuilding);
        Console.WriteLine("Year 2020:");
        PrintBuildInfo(1, buildingOne);
        PrintBuildInfo(2, buildingTwo);
        Console.WriteLine();
        Console.WriteLine("Many years pass.");
        Console.WriteLine();
        buildingOne.OccupancyRate = 0;
        buildingTwo.OccupancyRate = 1.0f;
        Console.WriteLine("Year 2043:");
        PrintBuildInfo(1, buildingOne);
        PrintBuildInfo(2, buildingTwo);
        Console.WriteLine();
        Console.WriteLine("Looks like people prefer taller buildings.");
        Console.WriteLine();
    }
    public static void PrintBuildInfo(int buildingNumber, BuildingBlueprint building)
    {
        Console.WriteLine($"Building {buildingNumber} has {building.NumberOfStories} floors, {building.NumberOfApartments} apartments, " +
          $"and is {building.OccupancyRate * 100.00}% occupied. Full? {building.IsFullyOccupied.ToString().ToLower()}");
    }
}
public class BuildingBlueprint
{
    private int numberOfStories;
    private int numberOfApartments;
    private float occupancyRate;
    private bool isFullyOccupied;
    public BuildingBlueprint()
    {
        numberOfStories = 10;
        numberOfApartments = 20;
        occupancyRate = 1.0f;
        isFullyOccupied = true;
    }
    public BuildingBlueprint(int inNumberOfStories, int inNumberOfApartments,float inOccupanyRate)
    {
        numberOfStories = inNumberOfStories;
        numberOfApartments = inNumberOfApartments;
        occupancyRate = inOccupanyRate;
    }
    public int NumberOfStories
    {
        get { return numberOfStories; }
    }
    public int NumberOfApartments
    {
        get { return numberOfApartments; }
    }
    public float OccupancyRate
    {
        get { return occupancyRate; }
        set 
        { 
            occupancyRate = value;
            isFullyOccupied = occupancyRate == 1;
        }
    }
    public bool IsFullyOccupied
    {
        get { return isFullyOccupied; }
    }
}
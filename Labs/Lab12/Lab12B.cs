using System;

public class Lab12B
{
    public static void Main(String[] args)
    {
        Dog dog = new Dog();
        Console.WriteLine("You are about to create a dog.");
        Console.Write("How old is the dog: ");
        dog.age = Convert.ToInt32(Console.ReadLine());
        Console.Write("How much does the dog weigh: ");
        dog.weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("What is the dog's name: ");
        dog.name = Console.ReadLine();
        Console.Write("What color is the dog: ");
        dog.furColor = Console.ReadLine();
        Console.Write("What breed is the dog: ");
        dog.breed = Console.ReadLine();
        PrintMessage(dog);
        dog.bark();
        Console.Write($"{dog.name} is hungry, how much should he eat: ");
        double addtoWeight = Convert.ToDouble(Console.ReadLine());
        dog.eat(addtoWeight);
        Console.Write($"{dog.name} isn't a very good name. What should they be renamed to: ");
        string newName = Console.ReadLine();
        dog.rename(newName);
        PrintMessage(dog);
    }
    public static void PrintMessage(Dog dog)
    {
        Console.WriteLine();
        Console.WriteLine($"{dog.name} is a {dog.age} year old {dog.furColor} {dog.breed} that weighs {dog.weight} lbs.");
        Console.WriteLine();
    }
}
public class Dog
{
    public int age { get; set; }
    public double weight { get; set; }
    public string name { get; set; }
    public string furColor { get; set; }
    public string breed { get; set; }

    public void bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
    public void rename(string newName)
    {
        name = newName;
    }

    public void eat(double addToWeight)
    {
        weight += addToWeight;
    }
}
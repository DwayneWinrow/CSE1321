using System;

class Assignment5A
{
    static void Main(string[] args)
    {
        Console.WriteLine($"[Top 10 Friend's List]");
        int intChoice = 0;
        var namesOfFriends = new string[10];
        string newName = string.Empty;
        while (intChoice != 4)
        {
            Console.WriteLine($"What would you like to do?");
            Console.WriteLine($"1) Enter a friend’s name");
            Console.WriteLine($"2) Replace a friend’s name");
            Console.WriteLine($"3) Display your friends list");
            Console.WriteLine($"4) Quit");
            Console.Write($"Your choice: ");
            
            intChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            
            switch (intChoice)
            {
                case 1:
                    Console.Write($"Enter a name: ");
                    newName = Console.ReadLine();
                    if (CheckIfNameExists(namesOfFriends, newName))
                    {
                        Console.WriteLine($"Sorry, {newName} is already on the list!");
                    }
                    else
                    {
                        if(!AddNameWhereVacant(namesOfFriends, newName))
                        {
                            Console.WriteLine($"Sorry, your friends list is full!");
                        }
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write($"Enter a name: ");
                    newName = Console.ReadLine();
                    Console.Write($"Enter an index: ");
                    int indexNumber = Convert.ToInt32(Console.ReadLine());
                    string oldName = AddNameByIndex(namesOfFriends, newName, indexNumber);
                    if (string.IsNullOrEmpty(oldName))
                    {
                        Console.WriteLine($"Sorry, that’s an invalid command!");
                    }
                    else
                    {
                        Console.WriteLine($"{newName} has replaced {oldName} on your friends list!");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write($"Friend's List: ");
                    Console.WriteLine();
                    PrintList(namesOfFriends);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine($"Sorry, that’s an invalid command!");
                    break;
            }
        }
        Console.WriteLine($"[Program Ends]");
    }
    private static bool CheckIfNameExists(string[] nameArray, string newName)
    {
        bool rtnStatus = false;
        foreach (string name in nameArray)
        {
            if (name == newName)
            {
                rtnStatus =true;
                break;
            } 
        }
        return rtnStatus;
    }
    private static bool AddNameWhereVacant(string[] nameArray, string newName)
    {
        bool booNameAdded = false;
        for(int i = 0; i < nameArray.Length; i++)
        {
            if (nameArray[i] == null)
            { 
                nameArray[i] = newName;
                booNameAdded = true;    
                break;
            }
        }
        return booNameAdded;
    }
    private static string AddNameByIndex(string[] nameArray, string newName, int indexNumber)
    {
        string rtnReplaceName = string.Empty;
        if (indexNumber < nameArray.Length)
        {
            rtnReplaceName = nameArray[indexNumber];
            nameArray[indexNumber] = newName;
        }
        return rtnReplaceName;
    }
    private static void PrintList(string[] nameArray)
    {
        for(int i = 0;i < nameArray.Length;i++)
        {
            Console.WriteLine($"{i+1}) {nameArray[i]}");
        }
        Console.WriteLine();
    }
}

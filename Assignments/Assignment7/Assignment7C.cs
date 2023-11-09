using System;

class Assignment7C
{
    static void Main(string[] args)
    {
        int threeGallonCan =0;
        int fiveGallonCan = 0;
        Console.WriteLine("[4 Gallons of Water]");
        while (fiveGallonCan!=4)
        {
            Console.WriteLine($"The 3 gallon can has {threeGallonCan} gallons of water. The 5 gallon can has {fiveGallonCan} gallons of water.\n");
            Console.WriteLine("Options ");
            Console.WriteLine("1. Fill the 5 gallon can from the fountain");
            Console.WriteLine("2. Fill the 3 gallon can from the fountain");
            Console.WriteLine("3. Pour the 5 gallon can into the 3 gallon jug");
            Console.WriteLine("4. Pour the 3 gallon can into the 5 gallon jug");
            Console.WriteLine("5. Empty the 5 gallon can into the fountain");
            Console.WriteLine("6. Empty the 3 gallon can into the fountain");
            Console.WriteLine("What will you do? \n");
            int intOption = Convert.ToInt32(Console.ReadLine());
            switch (intOption)
            {
                case 1:
                    fiveGallonCan = 5;
                    break;
                case 2:
                   threeGallonCan = 3;
                    break;
                case 3:
                    while (threeGallonCan < 3 && fiveGallonCan != 0)
                    {
                        threeGallonCan++;
                        fiveGallonCan--;
                    }
                    break;
                case 4:
                    while(fiveGallonCan < 5 && threeGallonCan != 0)
                    {
                        fiveGallonCan++;
                        threeGallonCan--;
                    }
                    break;
                case 5:
                    fiveGallonCan = 0;
                    break;
                case 6:
                    threeGallonCan =0;
                    break;
            }
           
        }
        Console.WriteLine($"The 3 gallon can has {threeGallonCan} gallons of water. The 5 gallon can has {fiveGallonCan} gallons of water.\n");

        Console.WriteLine("\nYou saved Bruce Willis and Samuel L. Jackson! You win!");
    }
    
}
using System;

class Assignment7A
{
    static void Main(string[] args)
    {
        Console.WriteLine("[SVG Class]");
        Console.Write("Rectangle width: ");
        Console.Write("Rectangle height: ");
        Console.Write("Fill color: ");
        Console.Write("Stroke color: ");
        int optionSelection = 0;
        while (optionSelection != 5)
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1) Change the Rectangle size ");
            Console.WriteLine("2) Update the Fill and Stroke settings ");
            Console.WriteLine("3) Move the Rectangle ");
            Console.WriteLine("4) Print valid XML ");
            Console.WriteLine("5) Quit");
            optionSelection = Convert.ToInt32(Console.ReadLine());
            switch (optionSelection)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}

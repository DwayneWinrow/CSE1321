using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Assignment1B2
{
    static void Main(string[] args)
    {
        string buying1;
        int howMany1;
        decimal costAmount1;
        string buying2;
        int howMany2;
        decimal costAmount2;
        Console.Write("What're you buying? ");
        buying1 = Console.ReadLine();
        Console.Write("How many? ");
        howMany1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("What do they cost? ");
        costAmount1 = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("What else're you buying? ");
        buying2 = Console.ReadLine();
        Console.Write("How many? ");
        howMany2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("What do they cost? ");
        costAmount2 = Convert.ToDecimal(Console.ReadLine());

        decimal subTotal1 = Convert.ToDecimal(howMany1 * costAmount1);
        decimal subTotal2 = Convert.ToDecimal(howMany2 * costAmount2);


        Console.Write("Your list: \n");
        Console.Write("----\n");
        Console.Write(buying1 + " (" + howMany1 + ")\n" );
        Console.Write("$"+ string.Format("{0:#.00}", Convert.ToDecimal(costAmount1)) + " ($" + string.Format("{0:#.00}", subTotal1) + " total)");
        Console.Write("\n\n");
        Console.Write(buying2 + " (" + howMany2 + ")\n");
        Console.Write("$" + string.Format("{0:#.00}", Convert.ToDecimal(costAmount2)) + " ($" + string.Format("{0:#.00}", subTotal2) + " total)");
        Console.Write("\n\n");
        Console.Write("Total Cost: "+ string.Format("{0:#.00}", Convert.ToDecimal(subTotal1 + subTotal2)));
        Console.Write("\n----");
        Console.Write("\n\n");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Assignment1B
{
    static void Main(string[] args)
    {
        Console.Write("[What to Tip]\n");
        
        Console.Write("Enter the total price of the meal: ");
        double totalPrice = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the local tax rate: ");
        double localTaxRate = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the service charge: ");
        double serviceCharge = Convert.ToDouble(Console.ReadLine());

        var total_tax = totalPrice * localTaxRate;
        var subTotal = totalPrice + serviceCharge;
        Console.WriteLine($"\nThe subtotal is ${subTotal.ToString("0.####")}\n");

        double tip_10 = subTotal * .10;
        double tip_25 = subTotal * .25;
        
        double total_10 = tip_10 + subTotal + total_tax;
        double total_25 = tip_25 + subTotal + total_tax;

        Console.WriteLine($"A 10% tip would be ${tip_10.ToString("0.####")}");
        Console.WriteLine($"The total would be ${total_10.ToString("0.####")}\n");

        Console.WriteLine($"A 25% tip would be ${tip_25.ToString("0.####")}");
        Console.WriteLine($"The total would be ${total_25.ToString("0.####")}\n");


    }
}
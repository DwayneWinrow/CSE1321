using System;

class Assignment3A
{
    static void Main(string[] args)
    {
        Console.WriteLine("[WebMd Checker]");
        Console.Write("What is your suspected illness? ");
        string illness = Console.ReadLine();
        string yesNo = "N";
        switch (illness.ToUpper())
        {
            case "HGPS":
                Console.Write("Do you have brittle bones? ");
                yesNo = Console.ReadLine();
                if (yesNo.ToUpper() == "Y")
                {
                    Console.WriteLine("It is possible that you have HGPS ");
                }
                else
                {
                    Console.WriteLine("It is not likely that you have HGPS ");
                }
                break;
            case "LUPUS":
                Console.WriteLine("It is not likely that you have Lupus ");
                break;
            case "BOKTER SYNDROME":
                Console.Write("Do you have a Vitamin C deficiency? ");
                yesNo = Console.ReadLine();
                if (yesNo.ToUpper() == "Y")
                {
                    Console.Write("Are you a sailor? ");
                    yesNo = Console.ReadLine();
                    if (yesNo.ToUpper() == "Y")
                    {
                        Console.WriteLine("It is likely that you have Bokter Syndrome");
                    }
                    else
                    {
                        Console.WriteLine("It is not likely that you have Bokter Syndrome");
                    }
                }
                else
                {
                    Console.Write("It is not likely that you have Bokter Syndrome");
                }
                break;
            default:
                Console.Write("\nInvalid Input. Please restart application.\n");
                break;
        }
        Console.WriteLine();
    }
}
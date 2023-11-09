using System;

public class Lab5A
{

    public static void Main(String[] args)
    {
        char DoYouHaveALicense;
        char DoYouHaveACommercialLicense;
        const char YES = 'Y';
        const char NO = 'N';

        Console.Write($"Do you have a driving permit (Y/N)? ");
        DoYouHaveALicense = char.Parse(Console.ReadLine().ToUpper());
        if(DoYouHaveALicense == YES)
        {
            Console.Write($"Do you have a commercial driving license (Y/N)? ");
            DoYouHaveACommercialLicense = char.Parse(Console.ReadLine().ToUpper());
            if (DoYouHaveACommercialLicense == YES)
            {
                Console.WriteLine($"Congratulations! You can purchase a vehicle, let’s start talking options!\n");
            }
            else if (DoYouHaveACommercialLicense == NO)
            {
                Console.WriteLine($"Commercial driving license is a prerequisite to purchase a vehicle!\n");
            }
        }
        else if (DoYouHaveALicense == NO)
        {
            Console.WriteLine($"Driving permit is a prerequisite to purchase a vehicle!\n");
        }
    }
}


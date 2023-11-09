using System;

class Assignment3C
{
    static void Main(string[] args)
    {
        const string BMP = "BMP";
        const string PNG = "PNG";
        const string TIFF = "TIFF";
        const string INVALID_INPUT = "Invalid Input";
        Console.WriteLine("[Guess the Color Mode]");
        Console.Write("How many channels does your image have? ");
        try
        {
            int numberOfChannels = Convert.ToInt32(Console.ReadLine());
            if (numberOfChannels > 5) throw new Exception(INVALID_INPUT);
            if (numberOfChannels ==1 || numberOfChannels == 2)
            {
                Console.Write("It is a Grayscale image. ");
                EndAndWriteLastLine();
            }

            Console.Write("What is its BPC value? ");
            
            int BPCvalue = Convert.ToInt32(Console.ReadLine());

            if (BPCvalue != 8 && BPCvalue != 16 && BPCvalue != 32) throw new Exception(INVALID_INPUT);

            if ((numberOfChannels == 3 || numberOfChannels == 4) && BPCvalue == 32)
            {
                Console.Write("It is an RGB image. ");
                EndAndWriteLastLine();
            }

            Console.Write("What image format is it? ");

            string imageFormat = Console.ReadLine();

            var ValidFileFormat = imageFormat.Contains(BMP) || imageFormat.Contains(PNG) || imageFormat.Contains(TIFF);
            
            if (!ValidFileFormat) throw new Exception(INVALID_INPUT);
            
            if (imageFormat.Contains(PNG) && (numberOfChannels==3 || numberOfChannels==4))
            {
                Console.Write("It is an RGB image. "); 
            } 
            else if (imageFormat.Contains(TIFF) && (numberOfChannels == 4 || numberOfChannels == 5))
            {
                Console.Write("It is a CMYK image. ");
            } 
            else
            {
                Console.Write("This image’s color mode can not be determined. ");
            }

            EndAndWriteLastLine();
        }
        catch
        {
            InvalidInput();
        }
        Console.WriteLine();
    }
    static void InvalidInput()
    {
        Console.Write("This is invalid input. Please run the program again. \n");
        EndAndWriteLastLine();
    }
    static void EndAndWriteLastLine()
    {
        Console.WriteLine();
        Environment.Exit(0);
    }
}
using System;

class Assignment3C3
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Image Encoding Checker]");
        Console.Write("What is the image width? ");
        int widthValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the image height? ");
        int heightValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the file size (in bytes)? ");
        int fileByteValue = Convert.ToInt32(Console.ReadLine());
        if (widthValue <= 0 || heightValue <= 0 || fileByteValue <= 0)
        {
            Console.WriteLine("The information is invalid - please re-enter it. ");
            return;
        }
        long bytesPerChannel = (fileByteValue * 8) / (widthValue * heightValue * 3);
        switch(bytesPerChannel)
        {
            case 8:
                Console.WriteLine($"\nThe RGB image is encoded with {bytesPerChannel} bits per channel");
                break;
            case 16:
                Console.WriteLine($"\nThe RGB image is encoded with {bytesPerChannel} bits per channel");
                break;
            case 32:
                Console.WriteLine($"\nThe RGB image is encoded with {bytesPerChannel} bits per channel");
                break;
            default:
                Console.WriteLine($"\nThis outside the range. We cannot read this encoding.");
                break;
        }
        Console.WriteLine();
    }
}
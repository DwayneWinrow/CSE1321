using System;

class Assignment4B
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Plus Sign ASCII Art]");
        Console.Write("Font-size: ");
        int intFontSize = Convert.ToInt32(Console.ReadLine());
        Console.Write("Font-weight: ");
        int intFontWeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Drawing with text...\n");
        int leftPosition = (intFontSize * 2) - intFontWeight;
        int rightPosition = (intFontSize * 2) + intFontWeight;
        DrawTopOrBottonOfPlusSign(intFontSize, intFontWeight);
        for (int i = 0; i < intFontWeight; i++)
        {
            for (int j = 0; j < intFontSize * 2 + intFontWeight; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        DrawTopOrBottonOfPlusSign(intFontSize, intFontWeight);

    }
    private static void DrawTopOrBottonOfPlusSign(int intFontSize, int intFontWeight)
    {
        for (int i = 0; i < intFontSize; i++)
        {
            for (int j = 0; j < intFontSize * 2; j++)
            {
                if (j >= intFontSize && j<=intFontSize)
                {
                    for (int k = 0; k < intFontWeight; k++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int k = 0; k < intFontWeight; k++)
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
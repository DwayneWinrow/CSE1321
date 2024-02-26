using System;

class Assignment7A
{
    static void Main(string[] args)
    {
        Console.Write(ArePalindromes("boy", "yob"));
    }
    public static bool ArePalindromes(string str1, string str2)
    {

        // Check if strings are null or empty
        if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
        {
            return false;
        }
        //1st turn string into char array
        char[] charArray = str2.ToCharArray();
        //2nd reverse char array
        Array.Reverse(charArray);

        //assign reversed string to new char array
        string temp = new string(charArray);

        // Check if reversed strings are equal
        return str1.Equals(temp);
    }
}
        //    Console.WriteLine("[SVG Class]");
        //    Console.Write("Rectangle width: ");
        //    float newWidth = Convert.ToSingle(Console.ReadLine());
        //    Console.Write("Rectangle height: ");
        //    float newHeight = Convert.ToSingle(Console.ReadLine());
        //    Console.Write("Fill color: ");
        //    string newfillColor = Console.ReadLine();
        //    Console.Write("Stroke color: ");
        //    string newStrokeColor = Console.ReadLine();
        //    SVGRect svgRectangle = new SVGRect(newWidth, newHeight, newfillColor, newStrokeColor);
        //    int optionSelection = 0;
        //    while (optionSelection != 5)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("What would you like to do? ");
        //        Console.WriteLine("1) Change the Rectangle size ");
        //        Console.WriteLine("2) Update the Fill and Stroke settings ");
        //        Console.WriteLine("3) Move the Rectangle ");
        //        Console.WriteLine("4) Print valid XML ");
        //        Console.WriteLine("5) Quit");
        //        Console.Write("Option: ");
        //        optionSelection = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine();
        //        switch (optionSelection)
        //        {
        //            case 1:
        //                Console.Write("Enter a width: ");
        //                newWidth = Convert.ToSingle(Console.ReadLine());
        //                Console.Write("Enter a height: ");
        //                newHeight = Convert.ToSingle(Console.ReadLine());
        //                Console.WriteLine(svgRectangle.setDimensions(newWidth, newHeight) ?
        //                    "Rectangle updated!" : "Invalid input - rectangle not changed");
        //                break;
        //            case 2:
        //                Console.Write("Enter a new fill color: ");
        //                newfillColor = Console.ReadLine();
        //                Console.Write("Enter a new stroke color: ");
        //                newStrokeColor = Console.ReadLine();
        //                Console.Write("Enter a new stroke width: ");
        //                float strokewidth = Convert.ToSingle(Console.ReadLine());
        //                Console.WriteLine(svgRectangle.set_fill_and_stroke(newfillColor, newStrokeColor, strokewidth) ?
        //                    "Rectangle updated!" : "Invalid input - rectangle not changed");
        //                break;
        //            case 3:
        //                Console.Write("Enter a new offset x: ");
        //                float newOffsetX = Convert.ToSingle(Console.ReadLine());
        //                Console.Write("Enter a new offset y: ");
        //                float newOffsetY = Convert.ToSingle(Console.ReadLine());
        //                svgRectangle.setOffsets(newOffsetX, newOffsetY);
        //                Console.WriteLine("Rectangle updated!");
        //                break;
        //            case 4:
        //                svgRectangle.print_XML();
        //                break;
        //            case 5:
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Closing!");



public class SVGRect
{
    private float lwidth;
    private float lheight;
    private string lfillColor = string.Empty;
    private string lstrokeColor = string.Empty;
    private float lstrokeWidth;
    private float loffsetX;
    private float loffsetY;
    public SVGRect()
    {
        lwidth = 1;
        lheight = 1;
        lfillColor = "#000FFF";
        lstrokeColor = "#0F0F0F";
        lstrokeWidth = 1.0f;
        loffsetX = 0;
        loffsetY = 0;
    }
    public SVGRect(float fwidth,float fheight, string fillColor, string strokeColor)
    {
        lwidth = fwidth;
        lheight = fheight;
        lfillColor = fillColor;
        lstrokeColor = strokeColor;
        lstrokeWidth = 1.0f;
        loffsetX = 0;
        loffsetY = 0;
    }
    public bool setDimensions(float width, float height)
    {
        if(width <= 0 || height <= 0)
            return false;

        lwidth = width;
        lheight = height;
        
        return true;
    }
    public void setOffsets(float offsetX, float offsetY)
    {
        loffsetX = offsetX;
        loffsetY = offsetY;
    }
    public bool set_fill_and_stroke(string fillColor, string strokeColor, float strokeWidth)
    {
        if (strokeWidth <= 0)
            return false;
        lfillColor = fillColor;
        lstrokeColor = strokeColor;
        lstrokeWidth = strokeWidth;
        return true;
    }
    public void print_XML()
    {
        Console.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        Console.WriteLine("<svg");
        Console.WriteLine("   xmlns=\"http://www.w3.org/2000/svg");                                 
        Console.WriteLine("   xmlns:svg=\"http://www.w3.org/2000/svg\"");
        Console.WriteLine("  <rect");
        Console.WriteLine($"    style=\"fill:{lfillColor}; stroke:{lstrokeColor}; stroke-width:{lstrokeWidth}\"");
        Console.WriteLine($"    width=\"{lwidth}\"");
        Console.WriteLine($"    width=\"{lheight}\"");
        Console.WriteLine($"    x=\"{loffsetX}\"");
        Console.WriteLine($"    y=\"{loffsetY}\" />");
        Console.WriteLine("svg>");
    }
}


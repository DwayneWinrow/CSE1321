using System;

class Assignment7B
{
    static void Main(string[] args)
    {
        Console.WriteLine("[X PixMap Editor]");
        string[] colorMapArray = new string[4];
        string[,] imageArray;
        int image_width;
        int image_height;
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter a hexadecimal color for color {i+1}: ");
            string hexColorValue = Console.ReadLine();
            Console.Write($"Enter a letter to represent this color: ");
            string letterValue = Console.ReadLine();
            colorMapArray[i] =$"\"{letterValue}\",\"#{hexColorValue}\""; 
        }
        Console.WriteLine();
        Console.Write($"Enter a width: ");
        image_width= Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter a height: ");
        image_height = Convert.ToInt32(Console.ReadLine());
        imageArray = new string[image_height,image_width];
        for (int i = 0; i < image_height; i++)
        {
            for (int j = 0; j < image_width; j++)
            {
                imageArray[i,j] = colorMapArray[0].Split(',')[0];
            }
        }
        int pickOption = 0;
        while(pickOption!=4)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1) Set a color");
            Console.WriteLine("2) Replace colors");
            Console.WriteLine("3) Print X PixMap");
            Console.WriteLine("4) Quit");
            Console.Write("Choice: ");
            pickOption = Convert.ToInt32(Console.ReadLine());
            switch (pickOption)
            {
                case 1:
                    Console.Write("Enter a row index: ");
                    int rowValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a column index: ");
                    int colValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a color: ");
                    string setColorValue = Console.ReadLine();
                    setColor(setColorValue, colValue, rowValue);
                    break;
                case 2:
                    Console.Write("Enter the color to replace: ");
                    string replaceThisColor = Console.ReadLine();
                    Console.Write("Enter the new color: ");
                    string newColor = Console.ReadLine();
                    replaceColor(imageArray, image_height, image_width, replaceThisColor, newColor);
                    break;
                case 3:
                    printXPixMap(colorMapArray,imageArray,image_width,image_height);
                    break;
                case 4:
                    break;
            }

        }
        Console.WriteLine("[Closing...]");
    }

    public static void setColor(string setColorValue, int image_height, int image_width)
    {
       
        //if (checkIfValidColor(inputColor))
        //{
        //image[image_width][image_width - 1] = inputColor;
        //    System.out.println("Color updated!");
        //}
        //else
        //{
        //    System.out.println("Invalid color!");
        //}
    }

    public static void replaceColor(string[,] imageArray,int image_height, int image_width,
        string replaceColor, string newColor)
    {
        for (int i = 0; i < image_height; i++)
        {
            for (int j = 0; j < image_width; j++)
            {
                if (imageArray[i, j].Equals(replaceColor))
                {
                    imageArray[i,j] = newColor;
                }
            }
        }
    }

    public static void printXPixMap(string[] image_colors_array, string[,] image_pixels_array,
        int image_width, int image_height)
    {
        Console.WriteLine($"#define image_format 1");
        Console.WriteLine($"#define image_width {image_width}");
        Console.WriteLine($"#define image_height {image_height}");
        Console.WriteLine($"#define image_ncolors {image_colors_array.Length-1}");
        Console.WriteLine($"#define image_chars_per_pixel 1");
        Console.WriteLine("static char *image_colors[] = {");
        string commas = string.Empty;
        for (int i = 0; i < image_colors_array.Length; i++)
        {
            //if (i < image_colors_array.Length - 1)
            //    commas = ",";
            Console.WriteLine($"{image_colors_array[i]}{commas}");
        }
        Console.WriteLine("};");
        Console.WriteLine("static char *image_pixels[] = {");
        for (int i = 0; i < image_pixels_array.Length; i++)
        {
            for (int j = 0; j < image_pixels_array.Length; j++)
            {
                //if (i < image_pixels_array.Length - 1)
                //    commas = ",";
                Console.WriteLine($"{image_pixels_array[i,j]}{commas}");
            }
        }
        Console.WriteLine("};");
    }

    public static bool checkIfValidColor(string[] arrayOfColors, string check4color)
    {
        foreach (string oneColor in arrayOfColors)
        {
            if(oneColor == check4color)
            {
                return true;
            }
        }
        return false;
    }
   
}
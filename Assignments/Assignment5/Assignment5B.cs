using System;

class Assignment5B
{
    static void Main(string[] args)
    {
        string[,] maze = new string[,]
        { 
            { "_", "N", "_", "N", "N" }, 
            { "_", "N", "_", "N", "_" }, 
            { "_", "_", "_", "N", "_" }, 
            { "N", "N", "_", "_", "W" }, 
            { "_", "_", "_", "N", "N" } 
        };
        int currentPosX = 4;
        int currentPosY = 0;
        int mazeRow = maze.GetLength(0);
        int mazeColumn = maze.GetLength(1);
        maze[currentPosX, currentPosY] = "P";
        Console.WriteLine("[Maze Game]");
        for (int i = 0; i < mazeRow; i++)
        {
            for (int j = 0; j < mazeColumn; j++)
            {
               Console.Write(maze[i,j] + ".");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        string curState = "_";
        while (!curState.Equals("N") && !curState.Equals("W"))
        {  
            Console.Write("Which direction do you want to move? ");
            string movement = Console.ReadLine().ToUpper();
            Console.WriteLine();
            int x = 0;
            int y = 0;
            switch (movement.ToUpper())
            {
                case "UP":
                    x = currentPosX - 1;
                    y = currentPosY;
                    break;
                case "DOWN":
                    x = currentPosX + 1;
                    y = currentPosY;
                    break;
                case "LEFT":
                    x = currentPosX;
                    y = currentPosY - 1;
                    break;
                case "RIGHT":
                    x = currentPosX;
                    y = currentPosY + 1;
                    break;
                default:
                    Console.WriteLine("That’s not a valid direction!");
                    continue;
            }
            if (isMoveValid(x, y, mazeRow, mazeColumn))
            {
                maze[currentPosX, currentPosY] = "_";
                currentPosX = x;
                currentPosY = y;
                curState = maze[x,y]; 
                maze[currentPosX, currentPosY] = "P";
                for (int i = 0; i < mazeRow; i++)
                {
                    for (int j = 0; j < mazeColumn; j++)
                    {
                        Console.Write(maze[i,j] + ".");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You can't move there - it's out of bounds!");
            }
        }
        if (curState.Equals("N"))
        {
            Console.WriteLine("You hit a wall – Game Over!");
        }
        else
        {
            Console.WriteLine("\nYou win!");
            Console.WriteLine("\nGoodbye!");
        }
        Environment.Exit(0);
    }
    private static bool isMoveValid(int positionX, int positionY, int mazeRows, int mazeColumns)
    {
        if(positionX < 0 || positionX >= mazeRows || positionY < 0 || positionY >= mazeColumns)
            return false;
        return true;
    }
}
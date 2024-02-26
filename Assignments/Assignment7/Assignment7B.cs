using System;

class Assignment7B
{
    static void Main(string[] args)
    {
        try
        {
            int Width, Height, Depth , XPos, YPos ,ZPos;

            Console.WriteLine("[3D Collision Tester]");
            Console.WriteLine("Create Player 1");
            Console.Write("Enter X position: ");
            XPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y position: ");
            YPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Z position: ");
            ZPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Hitbox Width: ");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Hitbox Height: ");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Hitbox Depth: ");
            Depth = Convert.ToInt32(Console.ReadLine());


            Player playerOne = new Player(Width, Height, Depth, XPos, YPos, ZPos);

            Console.WriteLine("Create Player 2");
            Console.Write("Enter X position: ");
            XPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y position: ");
            YPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Z position: ");
            ZPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Hitbox Width: ");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Hitbox Height: ");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Hitbox Depth: ");
            Depth = Convert.ToInt32(Console.ReadLine());

            Player playerTwo = new Player(Width, Height, Depth, XPos, YPos, ZPos);

            int playerOneOrPlayerTwo;
            string directionToMove;
            int distanceToMove;
           

            while (!playerOne.didTheyCollide(playerTwo))
            {

                Console.WriteLine($"\nPlayer 1 is at ({playerOne.XPosition},{ playerOne.YPosition},{playerOne.ZPosition}) " +
                    $"and Player 2 is at ({playerTwo.XPosition},{playerTwo.YPosition},{playerTwo.ZPosition})");
                Console.WriteLine("Which one do you want to move?");
                playerOneOrPlayerTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Which direction should Player {playerOneOrPlayerTwo} move (up, down, left, right, forward, or backword)?");
                directionToMove = Console.ReadLine().ToUpper();

                Console.WriteLine("How far should Player " + playerOneOrPlayerTwo + " move?");
                distanceToMove = Convert.ToInt32(Console.ReadLine());

                if (playerOneOrPlayerTwo == 1)
                {
                    MovePlayer(playerOne, directionToMove, distanceToMove);
                } 
                else 
                {
                    MovePlayer(playerTwo, directionToMove, distanceToMove);
                }
            }
            Console.WriteLine($"\nPlayer 1 is at ({playerOne.XPosition},{ playerOne.YPosition},{playerOne.ZPosition}) " +
                $"and Player 2 is at ({playerTwo.XPosition},{playerTwo.YPosition},{playerTwo.ZPosition})");

            Console.WriteLine("They collided!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nWrong Input !!!");
            Console.ReadLine();
        }
    }
    public static void MovePlayer(Player playerToMove, string directionToMove, int distanceToMove)
    {
        switch (directionToMove)
        {
            case "RIGHT":
                playerToMove.Move_X(distanceToMove);
                break;
            case "LEFT":
                playerToMove.Move_X(-distanceToMove);
                break;
            case "UP":
                playerToMove.Move_Y(distanceToMove);
                break;
            case "DOWN":
                playerToMove.Move_Y(-distanceToMove);
                break;
            case "FORWARD":
                playerToMove.Move_Z(distanceToMove);
                break;
            case "BACKWORD":
                playerToMove.Move_Z(-distanceToMove);
                break;
        }
    }
}
class Player
{
    int width;
    int height;
    int depth;
    int xPosition;
    int yPosition;
    int zPosition;
    public int Width 
    {
        get { return width; } 
        set { width = value; } 
    }
    public int Height {
        get { return height; }
        set { height = value; }
    }
    public int Depth {
        get { return depth; }
        set { depth = value; }
    }
    public int XPosition {
        get { return xPosition; }
        set { xPosition = value; }
    }
    public int YPosition {
        get { return yPosition; }
        set { yPosition = value; }
    }
    public int ZPosition
    {
        get { return zPosition; }
        set { zPosition = value; }
    }
    public Player(int Width, int Height, int Depth, int XPos, int YPos, int ZPos)
    {
        this.Width = Width;
        this.Height = Height;
        this.Depth = Depth;
        XPosition = XPos;
        YPosition = YPos;
        ZPosition = ZPos;
    }
    public void Move_X(int x_delta)
    {
        XPosition = XPosition + x_delta;
    }
    public void Move_Y(int y_delta)
    {
        YPosition = YPosition + y_delta;
    }
    public void Move_Z(int z_delta)
    {
        ZPosition = ZPosition + z_delta;
    }

    public bool didTheyCollide(Player player2)
    {
        if (this.XPosition < (player2.XPosition + player2.Width) && (this.XPosition + this.Width) > player2.XPosition && 
            this.YPosition < (player2.YPosition+ player2.Height) && (this.YPosition + this.Height) > player2.YPosition &&
            this.ZPosition < (player2.ZPosition + player2.Depth) && (this.ZPosition + this.Depth) > player2.ZPosition)
            return true;
        return false;
    }
}
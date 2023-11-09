using System;
public class Lab6C
{
    public static void Main(String[] args)
    {
        Console.WriteLine(Math.Floor(5.9));// prints 5

    }
    public static int a(int myNum)
    {
        if (myNum < 1)
        {
            return 4;
        }
        else
        {
            return myNum + a(myNum - 3);
        }
    }
}
class X
{
    private int a;
    public X(int b)
    {
        a = b;
    }
    public X(char c)
    {
        a = 10;
    }
    public override string ToString()
    {
        return "a is " + a;
    }
}
class Y : X
{
    public Y(int c) : base('x')
    {
    }
    public Y() : base(3)
    {
    }
}
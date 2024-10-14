using System;

class Rectangle
{
    private int width;
    private int height;
    
    public int Width
    {
        // try
        // {
        //     width <=0;
        // }
        // catch (System.Exception)
        // {
        //     throw new Exception("Invalid width");
        // }
        get {return value;}
        set { width = value;}
    }

    public int Height
    {
        // try
        // {
        //     height <=0;
        // }
        // catch (System.Exception)
        // {
            
        //     throw new Exception("Invalid height");
        // }
        get {return value;}
        set {height = value;}
    }

    public int AOC
    {
         Width * Height;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int w = int.Parse(args[0]);
        int h = int.Parse(args[1]);

        Rectangle r = new Rectangle();
        r.Width = w;
        r.Height = h;
        Console.WriteLine($"Area of rectangle is {r.AOC}");
    }
}
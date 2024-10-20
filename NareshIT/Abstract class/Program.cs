//Basic idea of abstract is Same Method name but Different logic for every method in that case we use abstract keyword.
using System.Diagnostics;
using Figure;

class Program
{
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle(10,10);
        Console.WriteLine("Area of Rectangle is "+r.Area());

        Triangle t = new Triangle(10,10,10);
        t.Area();
        Console.WriteLine("Area of Triangle is "+t.Area());
    }
}
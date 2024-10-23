using System.ComponentModel.DataAnnotations;

namespace Demo.Shapes;

public class Rectangle : IShape
{
    public void GetArea(int width ,int height)
    {
        Console.WriteLine(width * height);
    }
}
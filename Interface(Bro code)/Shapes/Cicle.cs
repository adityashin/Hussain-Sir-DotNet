namespace Demo.Shapes;

public class Circle : IShape
{
    public void GetRadius(int radius)
    {
        Console.WriteLine(3.14 * radius * radius);
    }
}
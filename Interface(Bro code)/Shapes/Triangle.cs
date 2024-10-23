namespace Demo.Shapes;

public class Triangle:IShape
{
    public void GetArea(int basee,int height)
    {
        Console.WriteLine( basee * height * (1/2));
    }
}
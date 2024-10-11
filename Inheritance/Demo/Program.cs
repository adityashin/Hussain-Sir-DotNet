class Base
{
    public void M1()
    {
        Console.WriteLine("Method 1 of Base");
    }
}
class Derived : Base
{
    public Derived()
    {
        Console.WriteLine("Default Constructor");
    }
    public void M2()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Method 2 of Derived");
    }
} 

class Program
{
    public static void Main(string[] args)
    {
        Derived d = new Derived();
        d.M2();
        d.M1();
    }
}

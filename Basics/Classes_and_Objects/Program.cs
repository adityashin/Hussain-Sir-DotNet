using System;
class Car
{
    public string make=" ";
    public string model=" ";

    public void start()
    {
        Console.WriteLine($"Car {make} {model} started");
    }
}

class Program{
    static void Main()
    {
        Car c = new Car();
        c.make = "Toyota";
        c.model = "VelFire";
        c.start();
    }
}
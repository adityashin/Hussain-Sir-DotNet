using System;

class Car{
    public string make = "";
    public string model = "";

    //constructor
    public Car(string make,string model)
    {
        this.make = make;
        this.model = model;
    }

    public void start()
    {
        Console.WriteLine($"{make} {model}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("JLR","Defender");
        car.start();
    }
}

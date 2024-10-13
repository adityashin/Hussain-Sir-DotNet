using System;

//Inheritance
//Inheritance allows a class to inherit from another class.

class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle Started");
    }
}

class Car : Vehicle
{
    public void Honk()
    {
        Console.WriteLine("Car Honked");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car c = new Car();
        c.Start();
        c.Honk();
    }
}
//Polymorphism Overriding
//override methods from a base class in derived class using virtual and override

using System;

class Vehicle
{
    public virtual void start()
    {
        Console.WriteLine("vehicle started");
    }
}

class Car:Vehicle
{
    public override void start()
    {
        Console.WriteLine("Car honked");
        base.start();
        
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Vehicle v = new Car();
        v.start();
    }
}
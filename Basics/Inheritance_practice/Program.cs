using System;

class Vehicle
{
    public void displayVehicle()
    {
        Console.WriteLine($"Display of Vehicle");
    }
}

class Bicycle : Vehicle
{
    private string price { get; set; }

    public void displayBicycle()
    {
        Console.WriteLine($"Display of Bicycle");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Bicycle b = new Bicycle();
        b.displayBicycle();
        b.displayVehicle();
    }
}

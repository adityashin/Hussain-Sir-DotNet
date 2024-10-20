namespace VehicleS
{
    public class Car : Vehicle
    {
        public override void MaxSpeed(int i)
        {
            Console.WriteLine($"Maximum speed of Car is {i}km/h");
        }
    }

    public class Bike : Vehicle
    {
        public override void MaxSpeed(int i)
        {
            Console.WriteLine($"Maximum speed of Bike is {i}km/h");
        }
    }

    public class Truck : Vehicle
    {
        public override void MaxSpeed(int i)
        {
            Console.WriteLine($"Maximum speed of Truck is {i}km/h");
        }
    }
}
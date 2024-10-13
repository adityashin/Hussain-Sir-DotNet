class Car
{
    private string make = "";
    public string model = "";

    public Car(string make,string model)
    {
        this.make = make;
        this.model = model;
    }

    public void DisplayMaker()
    {
        Console.WriteLine($"{make} {model}");
    }
}

class Program
{
    public static void Main()
    {
        Car c = new Car("JLR","Defender");
        c.DisplayMaker();
    }
}
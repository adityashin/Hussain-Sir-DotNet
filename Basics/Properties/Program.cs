using System;
class Car
{
    private string maker = "";


    public string Make  //make sure that properties don't have circle brackets
    {
        get { return maker; }
        set { maker = value; }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();

        //Calls the setter
        c.Make = "Tata_JLR";

        //Calls the getter
        Console.WriteLine(c.Make);

       


    }
}
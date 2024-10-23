using Demo.EMP;
using Demo.IpreyandIpredactor;
using Demo.Shapes;
class Program
{
    public static void Main(string[] args)
    {
        //Interface Defines a "Contract" that all the classes inheriting from should follow

        //An Interface declares "what a class should have"
        //An inheriting class defines "how it should do it"

        //Benefit = Security + Multiple Inheritance + "Plug and Play";

        //Intro
        Rabbit r = new Rabbit();
        Hawk h = new Hawk();
        Fish f = new Fish();

        //Problem 1
        Circle c = new Circle();
        Rectangle rec = new Rectangle();
        Triangle tr = new Triangle();

        //Problem 2
        FullTimeEmploye fe = new FullTimeEmploye();
        int Wage = fe.Work(1000,90);
        Console.WriteLine($"Total Wage the employee has earned is {0}",Wage);

        PartTimeEmployee pe = new PartTimeEmployee();
        int pt

        r.Flee();
        h.Hunt();
        f.Flee();
        f.Hunt();
        Console.WriteLine("\n\n");

        //problem1 solution
        c.GetRadius(10);
        rec.GetArea(10,10);
        tr.GetArea(99,89);

        
    }
    
    
}
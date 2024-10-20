using MO;
using Rect;
using Printer;
using Poly;
using VehicleS;
using Payroll.Pay;
using Ecommerce.discount;

class Program
{
    public static void Main(string[] args)
    {
         Demo.Test();
         Demo.Test(8,"a",99);

        Console.WriteLine("\n\n");
         Console.WriteLine( Rectangle.Area(10));
         Console.WriteLine(Rectangle.Area(10.10,10.10));
         Console.WriteLine(Rectangle.Area(9,9));
        
        Console.WriteLine("\n\n");
        Print p = new Print();
        p.print(24,"hello");

        classes2 c = new classes2();
        c.Test();


        //Exericise of Method Overriding
        Car cr = new Car();
        cr.MaxSpeed(200);

        Bike bk = new Bike();
        bk.MaxSpeed(120);

        Truck tk = new Truck();
        tk.MaxSpeed(80);

        Console.WriteLine("\n\n");
        HourlyEmployee he = new HourlyEmployee();
        int sal = he.calculate_payment(90000000);
        int hrsal=he.SalariedEmployee(1000,90);
        Console.WriteLine($"Annual package of emp is{sal}\n Total earning of emp is {hrsal}");

        Console.WriteLine("\n\n");
        RegularCustomer rc = new RegularCustomer();
        rc.getdiscount(100000);
        VIPCustomer vip = new VIPCustomer();
        vip.getdiscount(100000);
        EmployeeCustomer ec = new EmployeeCustomer();
        ec.getdiscount(100000);
    }
}
using System;

class Program
{
    public static void Main(string[] args)
    {
    //1
    float number = 369.369f;
    Console.WriteLine(number);

    //2
    
        double num = 10;
        string oe = num%2==0 ? "even" : "odd";
        Console.WriteLine(oe);

    //3
    
        int no=1;
        while(no<=10)
        {
            Console.WriteLine(no);
            ++no;
        }

    //4
    const double pi = 3.14;
    Console.WriteLine(pi);

    //5
    int day = 6;
    switch(day){
        case 1:
            Console.WriteLine("Sunday");
            break;
        case 2:
            Console.WriteLine("Monday");
            break;
        case 3:
            Console.WriteLine("Tuesday");
            break;
        case 4:
            Console.WriteLine("Wednesday");
            break;
        case 5:
            Console.WriteLine("Thursday");
            break;
        case 6:
            Console.WriteLine("Friday");
            break;
        case 7:
            Console.WriteLine("Saturday");
            break;
        default:
            Console.WriteLine("Invalid Number");
            break;
    }

    }

}
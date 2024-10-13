using System;
using System.ComponentModel;



class Program
{

    static void printmessage()
    {
        Console.WriteLine("Hello from Methods");
    }

    static int add(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        //Variable Data Types
        int num = 10;
        double pi = 3.14;
        string name = "aditya";
        bool isActive = true;

        Console.WriteLine("{0}", num);
        Console.WriteLine("{0}", pi);
        Console.WriteLine("{0}", name);
        Console.WriteLine("{0}", isActive);

        //Operators
        int a = 10;
        int b = 10;

        Console.WriteLine("add is {0}", a + b);
        Console.WriteLine("add is {0}", a - b);
        Console.WriteLine("add is {0}", a * b);
        Console.WriteLine("add is {0}", a / b);

        //Control Flow Statements
        int age = 18;
        if (age > 18)
            Console.WriteLine("Adult");
        Console.WriteLine("Child");

        //switch
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
        }

        //for loop
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("{0}", i);
        }

        Console.WriteLine("===================================");

        //while loop
        int x = 1;
        while (x <= 10)
        {
            Console.WriteLine(x);
            x++;
        }


        //Methods
        printmessage();
        int sum = add(a,b);
        Console.WriteLine("Sum is {0}", sum);
    }
}


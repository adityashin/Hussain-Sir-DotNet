using System;

//1
class Employee
{
    private string Name {get; set;}
    private int id {get; set;}
    private string dept {get; set;}

    public Employee()
    {
        Name = "abc";
        id = 01;
        dept = "IT";
    }

    public void display()
    {
        Console.WriteLine($"Name is {Name}");
        Console.WriteLine($"id is {id}");
        Console.WriteLine($"dept is {dept}");
    }
}

// //2
class Student
{
    private string name {get; set;}
    private int rollno {get; set;}
    private string address {get; set;}

    public Student()
    {
        name = "abc";
        rollno = 99;
        address = "Mumbai";
    }

    public void display()
    {
        Console.WriteLine($"Name is {name}");
        Console.WriteLine($"rollno is {rollno}");
        Console.WriteLine($"address is {address}");
    }
}

// //3
class Book
{
    private string Title {get; set;}
    private string Author {get; set;}

    public void display()
    {
        Console.WriteLine($"Title is {Title}");
        Console.WriteLine($"Author is {Author}");
    }
}

class Account
{
    private int balance {get; set;}
    private int acno {get; set;}

    public Account(int acno,int balance)
    {
        this.balance = balance;
        this.acno = acno;
    }

    public void display()
    {
        Console.WriteLine($"Balance is {balance}");
        Console.WriteLine($"Account Number is {acno}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee();
        e.display();
        Console.WriteLine("========================");

        Student s = new Student();
        s.display();
        Console.WriteLine("============================");

        Book b = new Book();
        b.display();
        Console.WriteLine("=============================");

        Account a = new Account(1234,1234);
        a.display();
        Console.WriteLine("============================");
    }
}
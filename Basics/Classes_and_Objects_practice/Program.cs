using System;

class Car
{
    public string Make = "";
    public string Model = "";
    public  string Year= "";

    public void display()
    {
        Console.WriteLine($"Maker of Car is {Make} Model is {Model} and Manufacturing years is {Year}");
    }
}

class Book
{
    public string title = "";
    public string author = "";
    public int ISBN;

    public void bestseller()
    {
      if(ISBN >1 && ISBN <=150)
      {
        Console.WriteLine("Average");
      }else if(ISBN >150 && ISBN <=300){
        Console.WriteLine("Good");
      }else if(ISBN >300){
        Console.WriteLine("BestSeller");
      }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car c1 = new Car();
        c1.Make = "JLR";
        c1.Model = "Defender";
        c1.Year = "2024";
        c1.display();

        Car c2 = new Car();
        c2.Make = "Tata";
        c2.Model = "Nexon";
        c2.Year = "2024";
        c2.display();

        Car c3 = new Car();
        c3.Make = "Mahindra";
        c3.Model = "XUV700";
        c3.Year = "2024";
        c3.display();

        Book b = new Book();
        b.title = "Psychology of Money";
        b.author = "Morgan Housal";
        b.ISBN = 50000000;
        b.bestseller();
    }
}
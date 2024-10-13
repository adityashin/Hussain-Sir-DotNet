using System;

//static members
//A static member belongs to class itself, not to a specific instance👇
class MathUtility
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
}

class 

class Progam
{
    public static void Main(string[] args)
    {
        int x = int.Parse(args[0]);
        int y = int.Parse(args[1]);
        int result = MathUtility.Add(x,y);
        Console.WriteLine("Addition of two numbers is {0}",result);
    }


}
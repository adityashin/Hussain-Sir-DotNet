using System;
class Program
{
    public static void Main(string[] args){
        Console.WriteLine("Welcome Investor");
        if(args.Length > 1){
            double p = double.Parse(args[0]);
            int n = int.Parse(args[1]);

            Console.WriteLine("Future value of risk free Investment is {0:0.00}",Investment.FutureValue(p,n,false));

            Console.WriteLine("Future value of risk-full Investment is {0:0.00}",Investment.FutureValue(p,n,true));

        }
    }
}
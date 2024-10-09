using System;

class Program
{

    static void Advice(ref Investment inv)
    {
        inv.Allowrisk(inv.TotalPayment()<500000);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome Investor!");
        if(args.Length > 1)
        {
            double p = double.Parse(args[0]);
            int n = int.Parse(args[1]);
            
            Investment myinv = new Investment(p,n);

            Console.WriteLine("Future value of riskfree investment is {0}",myinv.futurevalue());

            myinv.Allowrisk(true);

            Console.WriteLine("Future value of riskfull investment is {0}",myinv.futurevalue());

            Advice(ref myinv);

            Console.WriteLine("Future value of smart investment is {0}",myinv.futurevalue());


        }
    }
}
using System;

namespace LoanController;

using LoanController;

class Program
{
    static void Main()
    {
        Personal p = new Personal();
        p.Priciple = 1500000;
        p.Period = 5;

        Home h = new Home();
        h.Priciple = 2500000;
        h.Period = 3;

        Console.WriteLine("EMI for Personal Loan",p.GetEMI());

        Console.WriteLine("Emi for HomeLoan",h.GetEMI());
    }
}
using System;

struct Investment
{
    private double payment;
    private double count;
    private bool risk;
    
    //constructor
    public Investment(double amount,double years)
    {
        payment = amount;
        count = years;
        risk = false;
    }
    public void Allowrisk(bool yes){
        risk = yes;
    }

    public double TotalPayment()
    {
        return payment*count;
    }

    public double futurevalue()
    {
        double i = risk ? 0.08 : 0.06;
        return (payment / i) * (Math.Pow(1+i,count)-1);
    }

}
using System;

namespace Loan
{
    public abstract class Loan
    {

        public double Priciple
        {
            get; set;
        }
        public float Period
        {
            get; set;
        }


        public abstract float Getrate();

        public double GetEMI()
        {
            return Priciple * (1 + Getrate() * Period / 100) / (12 * Period);
        }
    }
}




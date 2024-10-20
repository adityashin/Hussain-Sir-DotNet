namespace Payroll.Pay
{
    public class Employee
    {
        public virtual int calculate_payment(int sal)
        {
            return sal / 12;
        }
        public virtual int SalariedEmployee(int Hrate,int Hour)
        {
            return Hrate * Hour;
        }
    }
}
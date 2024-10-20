namespace Payroll.Pay
{
    public class HourlyEmployee : Employee
    {
        public override int calculate_payment(int sal)
        {
            return sal / 12;
        }
        public override int SalariedEmployee(int Hrate,int Hour)
        {
            return Hrate * Hour;
        }
    }
}
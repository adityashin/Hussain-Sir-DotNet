using Ecommerce.discount;

namespace Payroll.Pay
{
    public class VIPCustomer : Customer
    {
        public override void getdiscount(int bill)
        {
            Console.WriteLine($"This is a VIP Customer and total Amount after discount of 20% is {bill-(bill*0.20)}$");
        }
    }
}
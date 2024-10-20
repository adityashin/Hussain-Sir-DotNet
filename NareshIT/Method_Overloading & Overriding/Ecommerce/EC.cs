namespace Ecommerce.discount
{
    public class EmployeeCustomer : Customer
    {
        public override void getdiscount(int bill)
        {
            Console.WriteLine($"This is Employee Customer and total amount after discount of 30% is {bill-(bill*0.30)}$");
        }
    }
}
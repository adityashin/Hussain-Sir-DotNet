namespace Ecommerce.discount
{
    public class RegularCustomer : Customer
    {
        public override void getdiscount(int bill)
        {
            Console.WriteLine($"This is a Regular Customer and Total_Amount after discount of 5% is {bill-(bill*0.05)}$");
        }
    }
}
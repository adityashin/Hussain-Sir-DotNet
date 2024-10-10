namespace Loan
{
    public class Personal : Loan
    {
        public override float Getrate()
        {
            if(Priciple <= 500000)
            {
                return 0.15f;
            }else{
                return 0.16f;
            }
        }
    }
}
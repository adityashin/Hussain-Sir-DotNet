using System.Security.Principal;

namespace Loan
{
    public class Home : Loan
    {
        public override float Getrate()
        {
            if(Priciple <= 2000000){
                return 0.10f;
            }else{
                return 0.11f;
            }
        }
    }
}
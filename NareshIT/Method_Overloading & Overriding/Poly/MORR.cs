namespace Poly
{
    public class classes1
    {
        public virtual void Test()
        {
            Console.WriteLine("Class 1 default constructor");
        }
    }
    public class classes2 : classes1
    {
        public override void Test()
        {
            Console.WriteLine("Class 2 is called");
        }
    }
}
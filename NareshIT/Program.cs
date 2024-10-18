class A
{

    public A(int i)
    {
        Console.WriteLine("Hello A's Here {0}",i);

    }
}
class B: A
{
   public B(int i):base(i)
    {
        Console.WriteLine("Hello B's here {0}",i);

    }
}
// class C:B
// {
//     public C()
//     {
//         Console.WriteLine("Hello C's here");
//     }
// }
class Program
{
    public static void Main(string[] args)
    {
        A aadi = new A(10);
        B bbb = new B(10);
        // C ccc = new C();

        Console.WriteLine(aadi);
        Console.WriteLine(bbb);
        // Console.WriteLine(ccc);

        // Console.WriteLine(aadi.GetType);
        // Console.WriteLine(bbb.GetType);
        // Console.WriteLine(ccc.GetType);
    }
}
using System.Net.Http.Headers;

namespace MO
{
    public class Demo
    {   
         public static void Test()
         {
            Console.WriteLine("1st Methods");       
         }

         public static void Test(int i)
         {
            Console.WriteLine("first argument method");
         }
         public static void Test(int i,string a)
         {
            Console.WriteLine("Two argument method");
         }
         
         public static void Test(int i, string a, float b)
         {
            Console.WriteLine("three argument method");
         }
    }
}
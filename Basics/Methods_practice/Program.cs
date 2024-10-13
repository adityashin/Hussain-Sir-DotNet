using System;

class Program
{
    //1
    static int Add(int a, int b)
    {
        return a + b;
    }

    // //2
    static int PrintSquare(int n)
    {
        int i=0;
        while(i<=n)
        {
            Console.WriteLine(i*i);
            ++i;
        }
        return 0;
    }

    // //3
    //palindrom

    //4
     static int ArraySum(int[] arr)
     {
        int num=0;
        int length = arr.Length;
        for(int i=0;i<=length;++i)
        {
            if(num <= arr[i])
                num = arr[i];
        }
        Console.WriteLine($"Biggest number in array is {num}");
        return 0;

     }

     //factorial
     static int factorial(int num)
     {
        int fact = 1;
        for(int i=1;i<=num;++i)
        {
            fact*=i;
        }
        Console.WriteLine($"Factorail of {num} is {fact}");
        return 0;
     }
    public static void Main(string[] args)
    {
        int addno1 = int.Parse(args[0]);
        int addno2 = int.Parse(args[1]);
        Console.WriteLine("Addition of two numbers is {0}", Add(addno1, addno2));

        int sqno = int.Parse(args[2]);
        PrintSquare(sqno);

        // int[] arrray = {1,2,3,4,5};
        // ArraySum(arrray);

        factorial(14);



    }
}
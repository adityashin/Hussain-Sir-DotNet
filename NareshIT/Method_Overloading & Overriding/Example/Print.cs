namespace Printer
{
    public class Print
    {
        public void print(int i)
        {
            Console.WriteLine($"int value is {i}");
        }

        public void print(double i)
        {
            Console.WriteLine($"double value is {i}");
        }

        public void print(string i)
        {
            Console.WriteLine($"string is {i}");
        }

        public void print(int i,string label)
        {
            Console.WriteLine($"{label} {i}");
        }
    }
}
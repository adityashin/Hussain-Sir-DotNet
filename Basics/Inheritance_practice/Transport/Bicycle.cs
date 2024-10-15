namespace Vehicle
{
    class Bicycle : Vehicle
    {
        public int price {get; set;}

        public Sales(string m,string md,string yr,int price):base(m,md,yr) { this.price = price}

        public void display()
        {
            Console.WriteLine($"Maker is {m}");
            Console.WriteLine($"Model is {md}");
            Console.WriteLine($"Year of Mft is {yr}");
            Console.WriteLine($"Price is {price}");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        //List = data structure that represents a list of objects that can be accessed by index.
        //similar to array, but can dynamically increase/decrease in size.
        //using System.collections.generic;

        List<String> Food = new List<String>();
        Food.Add("pizza");
        Food.Add("hamburger");
        Food.Add("hotdog");
        Food.Add("fries");

        Food.Remove("pizza");//TO remove any list from array
        Food.Insert(2,"Sushi");//WE can add items within specific sequence
        Console.WriteLine("Total length of Food list is "+Food.Count());

        Food.Sort();
        Console.WriteLine() Food.Reverse();

        foreach(string khana in Food)
        {
            Console.WriteLine(khana);
        }

        String[] food = new string[3];
        food[0] = "pizza";
        food[1] = "hamburger";
        food[2] = "hotdog";

        foreach(string item in food)
        {
            Console.WriteLine("Food item name is "+item);
        }
    }
}
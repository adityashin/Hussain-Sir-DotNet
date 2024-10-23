namespace Demo.IpreyandIpredactor;
    
    public class Rabbit : Iprey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }

    public class Hawk : Ipredactor
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk is searching for Food");
        }
    }

    public class Fish : Ipredactor , Iprey
    {
        public void Flee()
        {
            Console.WriteLine("The Fish Flee away once the fish see's the Shark");
        }

        public void Hunt()
        {
            Console.WriteLine("The Fish is Hunting down the Small Fishes");
        }
    }
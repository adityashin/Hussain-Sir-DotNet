namespace Transport
{
    class Vehicle
    {
        private string maker {get; set;}
        private string model {get; set;}
        private string year {get; set;}

        public Vehicle(string maker,string model,string year)
        {
            this.maker = maker;
            this.model = model;
            this.year = year;
        }

        public Vehicle() : this("a","b","c"){}

        
    }
}
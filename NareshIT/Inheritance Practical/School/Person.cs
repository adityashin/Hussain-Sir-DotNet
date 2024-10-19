using System.IO.Pipes;

namespace School
{
    public abstract class Person
    {
        public string id {get; set;}
        public string name {get; set;}
        public string address {get; set;}
        public string phone {get; set;}

        public Person(string id,string name,string address,string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public abstract void DisplayInfo();
    }
}

namespace School;

public class TeachingStaff : Person
{
    public string qualification {get; set;}
    public string subject {get; set;}

    public TeachingStaff(string id,string name,string address,string phone,string qualification,string subject):base(id,name,address,phone)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
        this.qualification = qualification;
        this.subject = subject;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"\n\n\nStaff id is {id} \nStaff name is {name}\n Residence address is {address}\n Phone number is {phone}");
        Console.WriteLine($"Qualification of staff is {qualification}\n Staff Teaching subject is {subject}");
    }
}
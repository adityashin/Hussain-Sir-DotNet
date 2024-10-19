namespace School
{
    public class Student:Person
    {
        public string classes {get; set;}
        public string marks {get; set;}
        public string grade {get; set;}
        public string fees {get; set;}  

        public Student(string id,string name,string address,string phone,string classes,string marks,string grade,string fees) : base(id,name,address,phone)
        {
            this.classes = classes;
            this.marks = marks;
            this.grade = grade;
            this.fees = fees;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"id is {id}\n Student name is {name}\n Address is {address}\n Phone number is {phone}");
            Console.WriteLine($"Student class is {classes}\n Marks is {marks}\n Grade Student got is {grade}\n Fees student paying is {fees}");
        }
            
    }
}
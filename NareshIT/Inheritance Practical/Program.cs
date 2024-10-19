using School;
class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student("01","aditya","solapur","Indian","CDAC","100%","A+","100000");
        s.DisplayInfo();

        TeachingStaff t = new TeachingStaff("01","Hussain","NYC","American","PHD in Quantam Physics","Every subject in Computer Science");
        t.DisplayInfo();
    }
}

namespace Demo.EMP;

public class PartTimeEmployee : IEmployee
{
    public int Work(int wage,int hour)
    {
        return wage * hour;
    }

    public int GetSalary(int salary=0,int com=0)
    {
        return salary + com;
    }
}
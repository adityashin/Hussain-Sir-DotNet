namespace Demo.EMP;

public class InternEmployee : IEmployee
{
    public int Work(int wage,int hour)
    {
        return wage * hour;
    }

    public int GetSalary(int salary=0,int comm =0)
    {
        return salary + comm;
    }
}
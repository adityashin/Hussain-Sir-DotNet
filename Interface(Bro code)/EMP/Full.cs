namespace Demo.EMP;

public class FullTimeEmploye : IEmployee
{
    public int Work(int wage,int hour)
    {
        return wage * hour;
    }
   public int GetSalary(int salary,int comm)
    {
        return salary + comm;
    }
}   
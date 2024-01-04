namespace HR;
public class Employee{
    protected float basic_sal;

    public virtual float CalculateSalary ()
    {
        return basic_sal;
    }
}

public class SalesEmployee:Employee{
    protected  float sales, comm;
    
    public SalesEmployee(){
     sales=500;
     comm=300;
     basic_sal=50000;
    }
    public new  virtual float CalculateSalary ()
    {
        return basic_sal+ (sales * comm) ;
    }
}
 


 public class SalesManager:SalesEmployee{
    private float bonus;
    
    public SalesManager(){
     sales=500;
     comm=300;
     basic_sal=50000;
     bonus=45000;
    }
    public override  float CalculateSalary ()
    {
        return basic_sal+ (sales * comm) + bonus ;
    }
}
 



namespace HR;
public class Employee{
    public float BasicSalary { get; set; }
    public float DailyAllowance { get; set; }
    public Employee(float sal,float da){
        this.BasicSalary=sal;
        this.DailyAllowance=da;
    }
    
    
    public virtual  float ComputePay(){
        return BasicSalary+ DailyAllowance* 22;
    }
}
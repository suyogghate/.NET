namespace HR;
public class Manager:Employee{
    public float Bonus{get;set;}

    public Manager(float bsal,float da, float bonus):base(bsal,da){
        this.Bonus=bonus;
    }
    public override float ComputePay()
    {
        return base.ComputePay()+ Bonus;
    }
}
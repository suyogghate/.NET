namespace HRAPP.Entities;

[Serializable]

public class Employee{

    public int Id{get;set;}
    public string Name{get;set;}
    public double Basic_Salary{get; set;}
    public double DA{get; set;}
    public double IT{get;set;}
    public Employee(int Id,string Name,double Basic_Salary,double DA,double IT){
        this.Id = Id;
        this.Name = Name;
        this.Basic_Salary = Basic_Salary;
        this.DA = DA;
        this.IT = IT;
      }
}

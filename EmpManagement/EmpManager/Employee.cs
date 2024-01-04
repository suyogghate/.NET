using System;

namespace Enroll;

public class Employee{
    public static int counter = 0;
    public int Id{get;}
    public string Name{get; set;}
    public double Basic_sal{get; set;}
    public double DA{get; set;}
    public double IT{get; set;}

    // public Employee(int Id){
    //     this.Id = Id;
    // }

    public Employee(){
        this.Id = ++counter;
        this.Name = string.Empty;
        this.Basic_sal = 0;
        this.DA = 0;
        this.IT = 0;
    }

    public Employee(string Name,double Basic_sal,double DA,double IT){
        this.Id = ++counter;
        this.Name = Name;
        this.Basic_sal = Basic_sal;
        this.DA = DA;
        this.IT = IT;
    }

    public double ComputeSal(){
        return Basic_sal+DA-IT;
    }

    public override string ToString(){
        return "Id: "+Id+" Name: "+Name+" Salary: "+ComputeSal();
    }
}


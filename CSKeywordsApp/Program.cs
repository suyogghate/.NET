//Declare Variables
//Value types :

//primitive types:
//int, float, char, boolean ,double, byte,
//struct, enum

//Refernce types
//class
//interface
//delegate
//event

// class
// concrete class 
// abstract class

using Handlers;
using Mathematics;
//using Calling;
using HR;

int a = 12;
int b = 45;
MathEngine mi=new MathEngine();
int result=mi.Addition(45,45);
int result2=mi.Subraction(45,45);
int result3=mi.Multiplication(45,3);
int result4=mi.Division(16,2);
mi.Swap(ref a, ref b);

mi.DisplayNames("suyog","harsh","sai","prateek","rahul","rohit");

Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);

mi.Calculate(12);

//Caller c1 = new Caller();
//c1.DisplayNames("suyog","harsh","sai","prateek","rahul","rohit");

Manager mgr=new Manager(8000,1000,10000);
Employee emp=mgr;
float salary=emp.ComputePay();

Console.WriteLine("Salary= "+ salary);

//Helper h = new Helper();

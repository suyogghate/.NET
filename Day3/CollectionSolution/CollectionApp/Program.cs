
using Library;
using HR;
using Editing;
using System.Collections;
using BI;

Books myfavouriteBooks=new Books();
string title1=myfavouriteBooks[0];
Console.WriteLine(" Title ="+ title1);
myfavouriteBooks[2]="Rich Dad Poor Dad";
Console.WriteLine("Title 2: "+myfavouriteBooks[1]);
Console.WriteLine("Title 3: "+myfavouriteBooks[2]);



//Rectangular multiDimensional Array
//Balanced multiDimensional Array
int [ , ] mtrx = new int [2, 3];
//Can initialize declaratively
int [ , ] mtrx2 = new int [2, 3] {
     {10, 20, 30},
     {40, 50, 60} 
    };


//Array of Array
int [ ] [ ] mtrxj = new int [3] [];
mtrxj[0]=new int[] {34,56,76,};
mtrxj[1]=new int[] {34,56,76,67,98,1,45,98,67};
mtrxj[2]=new int[] {98,67};


/*Employee sper= new SalesEmployee ();
float  salary= sper.CalculateSalary ();
 Console.WriteLine ("Salary= "+salary);*/

  Employee salesEmp=new SalesManager();
  float salary=salesEmp.CalculateSalary();
   Console.WriteLine ("Salary= "+salary);

//Consumer code
ISpellChecker checker= new MarathiSpellChecker ();
ArrayList words=checker.CheckSpelling ("Homosepian");

foreach( string word in words){
    Console.WriteLine(word);
}

CustomerDetails cstDetails=new CustomerDetails();
IOrderDetails iDetails=cstDetails;
iDetails.ShowDetails();
using Mathematics;
//using Calling;

namespace Handlers;
public static partial class Helper{
    public static  void DisplayNames(this MathEngine m,params string[]  names){ 
        foreach(string s in names){
            Console.WriteLine(s);
        }
    }
    public  static void Swap(this MathEngine m,ref int num1, ref  int num2){
        int temp=num1;
        num1=num2;
        num2=temp;

        Console.WriteLine("Num1: "+num1+" Num2: "+num2);
    }
    public static  void Calculate(this MathEngine m,int radius){
        const float PI=3.14f;
        float area=PI * radius * radius;
        float circumference=2 * PI * radius;

        Console.WriteLine("Area: "+area+" Circumference: "+circumference);
    }


    public static int Multiplication(this MathEngine m,int op1, int op2){
        return op1*op2;
    }

    public static int Division(this MathEngine m, int op1, int op2){
        return op1/op2;
    }
}
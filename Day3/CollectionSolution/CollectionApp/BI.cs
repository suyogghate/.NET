namespace BI;

public interface IPaymentDetails{
    void ShowDetails();
}
public interface IOrderDetails{
    void ShowDetails();
}

//Multiple Interface Inheritance
public class CustomerDetails:IPaymentDetails, IOrderDetails{
    //Explicit Inhterface Inheritance
    void IOrderDetails.ShowDetails(){
        Console.WriteLine("Order dtails");
    }

    void IPaymentDetails.ShowDetails(){
            Console.WriteLine("Payment dtails");
    }
}
namespace ProductStoreWebApp.Models;

public class Customer{
    public string? UserName{get; set;}
    public string? Password{get; set;}

    public override string ToString()
    {
        return "Username: "+UserName+" Password: "+Password;
    }
}
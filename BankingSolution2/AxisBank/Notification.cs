namespace Banking;

public delegate void Handler();

public class NotificationManager{
    public void SendEmail(){
        Console.WriteLine("Email send to registered email id!!!");
    }

    public void SendSMS(){
        Console.WriteLine("SMS send to yor registered mob no.!!!");
    }

    public void BlockAccount(){
        Console.WriteLine("Your account has been blocked temp....");
    }

    public void PayIncomeTax(){
        Console.WriteLine("Deducting Income tax from your account");
    }
}
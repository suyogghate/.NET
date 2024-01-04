using Banking;

NotificationManager mgr = new NotificationManager();

// Handler agent1 = new Handler(mgr.SendEmail);
// Handler agent2 = new Handler(mgr.SendSMS);
// Handler masterAgent = agent1;
// masterAgent += agent2;
// masterAgent.Invoke();

Account acct = new Account(5000);
acct.notify += new Handler(mgr.SendEmail);
acct.notify += new Handler(mgr.SendSMS);
acct.underBalance += new Handler(mgr.BlockAccount);
acct.overBalance += new Handler(mgr.PayIncomeTax);

acct.Deposit(460000);
acct.Withdraw(61000);

float remBalance = acct.Balance;
Console.WriteLine("Remaining balance: {0}",remBalance);


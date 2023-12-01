using System.Globalization;

namespace Exercise2;

public class TermDepositAccount : NormalAccount
{
    private double AnnualInterestPercentage { get; set; }
    private double AnnualInterestAmount { get; set; }
    
    private List<string>? _transactions = new();
    
    public override string ToString()
    {
        return $"AccountNumber           : {this.AccountNumber}\n" +
               $"DateOpened             : {this.DateOpened}\n" +
               $"Balance                 : {this.Balance}\n" +
               $"Nib                     : {this.Nib}\n" +
               $"AccountHolders          : {this.AccountHolders}\n" +
               $"AnnualInterestPercentage: {this.AnnualInterestPercentage}\n" +
               $"AnnualInterestAmount    : {this.AnnualInterestAmount}";
    }
    
    public TermDepositAccount(long accountNumber, DateTime dateTime, double balance, string nib,
        List<AccountHolder>? accountHolders, double annualInterestPercentage, double annualInterestAmount) : 
        base(accountNumber, dateTime, balance, nib, accountHolders)
    {
        this.AccountNumber = accountNumber;
        this.DateOpened = dateTime;
        this.Balance = balance;
        this.Nib = nib;
        this.AccountHolders = accountHolders;
        this.AnnualInterestPercentage = annualInterestPercentage;
        this.AnnualInterestAmount = annualInterestAmount;
    }
    
    public static TermDepositAccount OpenAccount(long accountNumber, DateTime dateTime, double balance, string nib,
        List<AccountHolder>? accountHolders, double annualInterestPercentage, double annualInterestAmount)
    {
        if (balance < 0)
        {
            throw new ArgumentException("Balance needs to be positive on a Normal Account.");
        }
        return new TermDepositAccount(accountNumber, dateTime, balance, nib, accountHolders, annualInterestPercentage, annualInterestAmount);
    }
    

    public double CalculateCurrentInterest()
    {
        TimeSpan time = DateTime.Now - this.DateOpened;
        double years = time.TotalDays / 365;
        double newBalance = this.Balance + (this.AnnualInterestPercentage * years * this.Balance);
        
        Console.WriteLine($"Your balance will be {Math.Round(newBalance, 2)} euros after the interest of {Math.Round(years, 0)} years is deposited.");

        return newBalance;
    }
    
    public new double Withdraw(double amount)
    {
        throw new ArgumentException("You can not withdraw from a term deposit account.");
            
    }
}
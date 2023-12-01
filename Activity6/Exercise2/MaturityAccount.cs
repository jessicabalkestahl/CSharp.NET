namespace Exercise2;

public class MaturityAccount : NormalAccount
{
    public string? Employer { get; set; }
    public string? EmployerNib { get; }
    public double NegativeLimit { get; set; }
    public double InterestPercentage { get; set; }
    
    public override string ToString()
    {
        return $"AccountNumber     : {this.AccountNumber}\n" +
               $"DateOpened       : {this.DateOpened}\n" +
               $"Balance           : {this.Balance}\n" +
               $"Nib               : {this.Nib}\n" +
               $"AccountHolders    : {this.AccountHolders}\n" +
               $"Employer          : {this.Employer}\n" +
               $"EmployerNib       : {this.EmployerNib}\n" +
               $"NegativeLimit     : {this.NegativeLimit}\n" +
               $"InterestPercentage: {this.InterestPercentage}";
    }

    public MaturityAccount(long accountNumber, DateTime dateTime, double balance, string nib,
        List<AccountHolder>? accountHolders, string employer, string employerNib, double negativeLimit, 
        double interestPercentage) : base(accountNumber, dateTime, balance, nib, accountHolders)
    {
        this.AccountNumber = accountNumber;
        this.DateOpened = dateTime;
        this.Balance = balance;
        this.Nib = nib;
        this.AccountHolders = accountHolders;
        this.Employer = employer;
        this.EmployerNib = employerNib;
        this.NegativeLimit = negativeLimit;
        this.InterestPercentage = interestPercentage;
    }
    
    public static MaturityAccount OpenAccount(long accountNumber, DateTime dateTime, double balance, string nib,
        List<AccountHolder>? accountHolders, string employer, string employerNib, double negativeLimit, 
        double interestPercentage)
    {
        if (balance < 0 - negativeLimit)
        {
            throw new ArgumentException("Balance can not fall below the negative level.");
        }
        return new MaturityAccount(accountNumber, dateTime, balance, nib, accountHolders, employer, 
            employerNib, negativeLimit, interestPercentage);
    }
    
    public new double Withdraw(double amount)
    {
        if (this.Balance - amount < 0 - NegativeLimit)
        {
            this.Transactions!.Add(this.GetDateFormatted() + $" Tried to withdraw {amount} from the account." );
            throw new ArgumentException("You can not withdraw more than your defined negative limit.");
        }

        this.Balance -= amount;
        this.Transactions!.Add(this.GetDateFormatted() + $" Withdrew {amount} from the account." );
        return this.Balance - amount;
    }
}
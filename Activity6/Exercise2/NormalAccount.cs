namespace Exercise2;

public class NormalAccount
{
    protected long AccountNumber { get; init; }
    protected DateTime DateOpened { get; init; }
    protected double Balance { get; set; }
    protected string? Nib { get; init; }
    public List<AccountHolder>? AccountHolders { get; set; }
    
    public List<string>? Transactions = new();
    public override string ToString()
    {
        return $"AccountNumber : {this.AccountNumber}\n" +
               $"DateOpened   : {this.DateOpened}\n" +
               $"Balance       : {this.Balance}\n" +
               $"Nib           : {this.Nib}\n" +
               $"AccountHolders: {this.AccountHolders}";
    }
    
    public NormalAccount(long accountNumber, DateTime dateTime, double balance, string nib, List<AccountHolder>? accountHolders)
    {
        this.AccountNumber = accountNumber;
        this.DateOpened = dateTime;
        this.Balance = balance;
        this.Nib = nib;
        this.AccountHolders = accountHolders;
    }

    protected string GetDateFormatted()
    {
        DateTime date = DateTime.Now;
        return date.ToString("dd/MM/yyyy HH:mm");
    }

    public static NormalAccount OpenAccount(long accountNumber, DateTime dateTime, double balance, string nib,
        List<AccountHolder>? accountHolders)
    {
        if (balance < 0)
        {
            throw new ArgumentException("Balance needs to be positive on a Normal Account.");
        }
        return new NormalAccount(accountNumber, dateTime, balance, nib, accountHolders);
    }

    public double Withdraw(double amount)
    {
        if (this.Balance - amount < 0)
        {
            this.Transactions!.Add(this.GetDateFormatted() + $" Tried to withdraw {amount} from the account." );
            throw new ArgumentException("You can not withdraw more than what you have in your account.");
        }

        this.Balance -= amount;
        Transactions!.Add(this.GetDateFormatted() + $" Withdrew {amount} from the account." );
        return this.Balance - amount;
    }

    public double Deposit(double amount)
    {
        this.Balance += amount;
        this.Transactions!.Add(this.GetDateFormatted() + $" Deposited {amount} on the account." );
        return this.Balance + amount;
    }

    public double GetBalance()
    {
        Console.WriteLine($"Current balance: {this.Balance}");
        return this.Balance;
    }

    public void GetLastFiveTransactions()
    {
        Console.WriteLine("=== Transactions ===");
        for (int i = this.Transactions!.Count; i-- > 0;)
        {
            Console.WriteLine(this.Transactions[i]);
            
            if (this.Transactions!.Count - 4 > i)
            {
                break;
            }
        }
    }
    

}
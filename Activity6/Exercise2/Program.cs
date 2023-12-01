
using System.Runtime.InteropServices.JavaScript;

namespace Exercise2
{
    internal static class AccountManager
    {
        public static void Main()
        {
            DateTime dateNormalAccount = new(2008, 6, 1, 7, 47, 0);
            AccountHolder holder1NormalAccount = new(1, "Jess");
            AccountHolder holder2NormalAccount = new(2, "Mi");
            List<AccountHolder>? holdersNormalAccount = null;
            holdersNormalAccount?.Add(holder1NormalAccount);
            holdersNormalAccount?.Add(holder2NormalAccount);
            NormalAccount normalAccount = NormalAccount.OpenAccount(1234, dateNormalAccount, 50000, "1234",
                holdersNormalAccount);
            
            
            DateTime dateTermAccount = new(2020, 1, 1, 10, 00, 0);
            AccountHolder holder1TermAccount = new(1, "Li");
            List<AccountHolder>? holdersTermAccount = null;
            holdersTermAccount?.Add(holder1TermAccount);
            TermDepositAccount termDepositAccount = TermDepositAccount.OpenAccount(5678, dateTermAccount, 2000, "5678",
                holdersTermAccount, 5, 60);

            
            DateTime dateMaturityAccount = new(2008, 6, 1, 7, 47, 0);
            AccountHolder holder1MaturityAccount = new(1, "Licinia");
            List<AccountHolder>? holdersMaturityAccount = null;
            holdersMaturityAccount?.Add(holder1MaturityAccount); 
            MaturityAccount maturityAccount = MaturityAccount.OpenAccount(9101, dateMaturityAccount, 10000, "9101", 
                holdersMaturityAccount, "Fabamaq", "5555", 1000, 10);

            normalAccount.Withdraw(100);
            normalAccount.Deposit(200);
            normalAccount.Withdraw(10000);
            normalAccount.GetLastFiveTransactions();
            normalAccount.GetBalance();

            Console.WriteLine();
            
            termDepositAccount.Deposit(500);
            termDepositAccount.Deposit(10000);
            termDepositAccount.GetLastFiveTransactions();
            termDepositAccount.GetBalance();
            termDepositAccount.CalculateCurrentInterest();
            
            Console.WriteLine();

            maturityAccount.Withdraw(5000);
            maturityAccount.Withdraw(2000);
            maturityAccount.Withdraw(1000);
            maturityAccount.Withdraw(500);
            maturityAccount.Withdraw(500);
            maturityAccount.Withdraw(1500);
            maturityAccount.GetLastFiveTransactions();
            maturityAccount.GetBalance();



        }
    }
}
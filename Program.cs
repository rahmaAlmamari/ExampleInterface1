namespace ExampleInterface1
{
    //1. IAccount interface ...
    public interface IAccount
    {
        string AccountNumber { get; }
        decimal Balance { get; }

        void Deposit(decimal amount);
    }
    //2. IWithdrawable interface ...
    public interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
    //3. IInterestBearing interface ...
    public interface IInterestBearing
    {
        decimal InterestRate { get; set; }
        void ApplyInterest();
    }
    //4. SavingsAccount class ...
    public class SavingsAccount : IAccount, IWithdrawable, IInterestBearing
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to savings account. New balance: { Balance: C}"); 
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from savings account. New balance:  { Balance: C} "); 
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public void ApplyInterest()
        {
            var interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Applied interest of {interest:C}. New balance: {Balance:C}");
        }

    }
    //5. CreditAccount class ...
    public class CreditAccount : IAccount, IWithdrawable
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public decimal CreditLimit { get; private set; }

        public CreditAccount(string accountNumber, decimal creditLimit)
        {
            AccountNumber = accountNumber;
            CreditLimit = creditLimit;
            Balance = -CreditLimit;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to credit account. New balance: {Balance:C}");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

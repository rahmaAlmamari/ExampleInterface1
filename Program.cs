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
    //4. 
    public class SavingsAccount : IAccount, IWithdrawable, IInterestBearing
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; set; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

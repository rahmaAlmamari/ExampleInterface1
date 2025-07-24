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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace ExampleInterface1
{
    public interface IAccount
    {
        string AccountNumber { get; }
        decimal Balance { get; }

        void Deposit(decimal amount);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

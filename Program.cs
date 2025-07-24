namespace ExampleInterface1
{
    public interface IAccount
    {
        string AccountNumber { get; }
        decimal Balance { get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

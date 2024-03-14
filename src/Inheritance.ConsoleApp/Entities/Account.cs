namespace Inheritance.ConsoleApp.Entities
{
    internal class Account(int number, string holder, double balance)
    {
        public int Number { get; private set; } = number;
        public string Holder { get; private set; } = holder;
        public double Balance { get; protected set; } = balance;

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

namespace SealedModifier.ConsoleApp.Entities
{
    internal class Account(int number, string holder, double balance)
    {
        public int Number { get; private set; } = number;
        public string Holder { get; private set; } = holder;
        public double Balance { get; protected set; } = balance;

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

// O modificador virtual permite que método da classe base (Account) seja modificada em subclasses (SavingsAccount).
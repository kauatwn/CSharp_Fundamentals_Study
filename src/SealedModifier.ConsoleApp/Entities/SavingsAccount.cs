namespace SealedModifier.ConsoleApp.Entities
{
    internal sealed class SavingsAccount(int number, string holder, double balance, double interestRate) : Account(number, holder, balance)
    {
        public double InterestRate { get; set; } = interestRate;

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            // Chama o método da superclasse (Account) e desconta mais 2.
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
namespace AbstractModifier.ConsoleApp.Entities
{
    internal sealed class SavingsAccount(int number, string holder, double balance, double interestRate) : Account(number, holder, balance)
    {
        public double InterestRate { get; set; } = interestRate;

        // O método de saque para SavingsAccount possui juros de $7.
        public override void Withdraw(double amount)
        {
            Balance -= amount + 7.0;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
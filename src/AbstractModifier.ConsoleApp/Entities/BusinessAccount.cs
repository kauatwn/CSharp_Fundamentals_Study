namespace AbstractModifier.ConsoleApp.Entities
{
    internal sealed class BusinessAccount(int number, string holder, double balance, double loanLimit) : Account(number, holder, balance)
    {
        public double LoanLimit { get; set; } = loanLimit;

        // O método de saque para BusinessAccount possui juros de $5.
        public override void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
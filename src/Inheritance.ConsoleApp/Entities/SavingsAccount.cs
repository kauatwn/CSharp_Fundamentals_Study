namespace Inheritance.ConsoleApp.Entities
{
    internal class SavingsAccount(int number, string holder, double balance, double interestRate) : Account(number, holder, balance)
    {
        public double InterestRate { get; set; } = interestRate;

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}

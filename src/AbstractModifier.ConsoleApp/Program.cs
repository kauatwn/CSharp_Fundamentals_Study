using AbstractModifier.ConsoleApp.Entities;

List<Account> accounts = [];

accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
accounts.Add(new BusinessAccount(1002, "Anna", 500.0, 200.0));

double sumBalance = 0.0;
foreach (var account in accounts)
{
    sumBalance += account.Balance;
}
Console.WriteLine($"Total balance: {sumBalance}\n");

sumBalance = 0.0;
foreach (var account in accounts)
{
    account.Withdraw(10.0);
    sumBalance += account.Balance;
    Console.WriteLine($"Updated balance for account {account.Number}: {account.Balance}");
}
Console.WriteLine($"\nTotal balance: {sumBalance}");
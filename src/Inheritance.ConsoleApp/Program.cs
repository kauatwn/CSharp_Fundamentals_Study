using Inheritance.ConsoleApp.Entities;

// Upcasting
Account acc1 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account acc2 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// Downcasting
BusinessAccount acc3 = (BusinessAccount)acc1;
acc3.Loan(100.0);

// O objeto acc2 é do tipo SavingsAccount. Portanto, ao tentar fazer o downcasting para BusinessAccount, ocorrerá uma exception.
//BusinessAccount acc4 = (BusinessAccount)acc2;

// Operador 'is' verifica o tipo, eliminando a necessidade do typeof.
if (acc2 is BusinessAccount)
{
    BusinessAccount acc4 = (BusinessAccount)acc2;
    acc4.Loan(200.0);
    Console.WriteLine("Loan!");
}

if (acc2 is SavingsAccount)
{
    // Operador 'as' faz conversões de tipo igual ao casting, porém de forma segura.
    SavingsAccount? acc4 = acc2 as SavingsAccount;
    acc4.UpdateBalance();
    Console.WriteLine("Update!");
}

// Se uma operação não for bem-sucedida, 'as' retorna null.
// Se uma operação não for bem-sucedida, o casting lança uma exception.
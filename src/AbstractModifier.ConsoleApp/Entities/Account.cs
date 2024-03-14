namespace AbstractModifier.ConsoleApp.Entities
{
    // Utiliza-se abstract em classes para impedir a instância de algo que é genérico.
    // Projetado para ser usado como uma estrutura básica ou genérica.
    // Em resumo, é uma boa prática para que outras classes possam derivar e fornecer implementações específicas.
    internal abstract class Account(int number, string holder, double balance)
    {
        public int Number { get; private set; } = number;
        public string Holder { get; private set; } = holder;
        public double Balance { get; protected set; } = balance;
        
        // Para métodos, utiliza-se quando deseja que classes derivadas da classe base tenha o mesmo método com comportamento diferente.
        public abstract void Withdraw(double amount);

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
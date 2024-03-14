namespace Interface.ConsoleApp.Services
{
    // Interface é uma abstração.
    // É algo genérico que as classes podem implementar.
    internal interface ITaxService
    {
        double Tax(double amount);
    }
}

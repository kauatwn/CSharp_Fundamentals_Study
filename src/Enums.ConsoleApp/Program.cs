using Enums.ConsoleApp.Entities;
using Enums.ConsoleApp.Enums;

var order = new Order
{
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

// Converte enum para string
string txt = OrderStatus.Processing.ToString();
Console.WriteLine(txt);

// Converte string para enum
var os = Enum.Parse<OrderStatus>("Shipped");
Console.WriteLine(os);
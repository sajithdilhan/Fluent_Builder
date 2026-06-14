
using Fluent_Builder;

var order1 = OrderBuilder.Empty()
    .WithId(1)
    .WithCreatedDate(DateTime.UtcNow)
    .WithStatus("Completed")
    .Build();

Console.WriteLine($"Order {order1.OrderId} has been {order1.OrderStatus} on {order1.CreatedDate}");


var order2 = OrderBuilder.Empty()
    .WithId(2)
    .WithStatus("Cancelled")
    .Build();

Console.WriteLine($"Order {order2.OrderId} has been {order2.OrderStatus} on {order2.CreatedDate}");

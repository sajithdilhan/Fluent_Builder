
var order = OrderBuilder.Empty()
    .WithId(1)
    .WithCreatedDate(DateTime.UtcNow)
    .WithStatus("Completed")
    .Build();

Console.WriteLine($"Order {order.OrderId} has been {order.OrderStatus} on {order.CreatedDate}");


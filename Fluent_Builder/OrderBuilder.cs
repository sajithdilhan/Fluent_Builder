namespace Fluent_Builder;

public class OrderBuilder
{
    private int _orderId { get; set; }
    private DateTime _createdDate { get; set; }
    private string _orderStatus { get; set; } = string.Empty;

    private OrderBuilder()
    {

    }

    public static OrderBuilder Empty() => new();

    public Order Build()
    {
        return new Order()
        {
            OrderId = _orderId,
            CreatedDate = _createdDate,
            OrderStatus = _orderStatus,
        };
    }

    public OrderBuilder WithStatus(string status)
    {
        _orderStatus = status;
        return this;
    }

    public OrderBuilder WithId(int id)
    {
        _orderId = id;
        return this;
    }

    public OrderBuilder WithCreatedDate(DateTime dateTime)
    {
        _createdDate = dateTime;

        return this;
    }
}
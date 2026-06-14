namespace Fluent_Builder;

public class Order
{
    public int OrderId { get; set; }
    public DateTime CreatedDate { get; set; }
    public string OrderStatus { get; set; } = string.Empty;
}
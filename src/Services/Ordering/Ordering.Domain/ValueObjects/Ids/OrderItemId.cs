namespace Ordering.Domain.ValueObjects.Ids;

public record OrderItemId : Id<Guid>
{
    private OrderItemId(Guid value) => Value = value;

    public static OrderItemId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new DomainException("OrderItemId cannot be empty.");
        }

        return new OrderItemId(value);
    }
}

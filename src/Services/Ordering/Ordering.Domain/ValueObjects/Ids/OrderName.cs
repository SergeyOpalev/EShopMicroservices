namespace Ordering.Domain.ValueObjects.Ids;

public record OrderName : Id<string>
{
    private const int DefaultLength = 5;

    private OrderName(string value) => Value = value;

    public static OrderName Of(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
        ArgumentOutOfRangeException.ThrowIfNotEqual(value.Length, DefaultLength, nameof(value));

        return new OrderName(value);
    }
}

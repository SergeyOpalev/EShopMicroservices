namespace Ordering.Domain.ValueObjects.Ids;

public record CustomerId : Id<Guid>
{
    private CustomerId(Guid value) => Value = value;    

    public static CustomerId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new DomainException("CustomerId cannot be empty.");
        }

        return new CustomerId(value);
    }
}

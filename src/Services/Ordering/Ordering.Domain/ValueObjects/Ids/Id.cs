namespace Ordering.Domain.ValueObjects.Ids;

public abstract record Id<T>
{
    public T? Value { get; protected set; }
}

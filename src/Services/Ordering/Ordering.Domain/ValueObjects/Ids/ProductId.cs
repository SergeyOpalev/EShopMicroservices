﻿namespace Ordering.Domain.ValueObjects.Ids;

public record ProductId : Id<Guid>
{
    private ProductId(Guid value) => Value = value;

    public static ProductId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new DomainException("ProductId cannot be empty.");
        }

        return new ProductId(value);
    }
}

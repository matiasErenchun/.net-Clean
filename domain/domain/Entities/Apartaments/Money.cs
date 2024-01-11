namespace domain.Entities;

public record Money(decimal amount, Currency currency)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.currency != second.currency)
        {
            throw new InvalidOperationException("not same currencies");
        }

        return new Money(first.amount + second.amount,first.currency);
    }

    public static Money Zero() => new(0, Currency.None);

    public static Money Zero(Currency currency) => new(0, currency);

    public bool IsZero() => this == Zero(currency);
}
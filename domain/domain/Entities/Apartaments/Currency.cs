namespace domain.Entities;

public record class Currency
{
    public static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");
    public static readonly Currency Clp = new("CLP");

    private Currency(string code) => Code = code;
    
    public string Code { get; init; }

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Eur,
        Clp
    };

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ?? throw new ApplicationException("erro type of money");
    }

}
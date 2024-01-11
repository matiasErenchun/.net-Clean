namespace domain.Entities.Bookings;

public class PricingService
{
    public PricengDetails CalculatePrice(Apartament apartament, DateRange period)
    {
        var currency = apartament.Price.currency;

        var priceForPeriod = new Money(
            apartament.Price.amount + period.LengthInDays, currency
        );

        var totalPrice = Money.Zero();
        totalPrice += priceForPeriod;
        return new PricengDetails(priceForPeriod, Money.Zero(), Money.Zero(), totalPrice);
    }
}
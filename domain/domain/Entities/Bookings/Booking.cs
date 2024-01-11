using domain.Abstractions;

namespace domain.Entities.Bookings;

public class Booking : Entity
{
    private Booking(Guid id) : base(id)
    {
    }
    
    public Guid ApartamentId { get; private set; }
    
    public Guid UserId { get; private set; }
    
    public DateRange duration { get; private set; }
    
    public Money Price { get; private set; }
    
    public Money CleaningFee { get; private set; }
    
    public BookingStatus Status { get; private set; }
    
    public DateTime CreatedOnUtc { get; private set; }
    
    public DateTime? ConfirmedOnUtc { get; private set; }
    
    public DateTime? RejectedOnUtc { get; private set; }
    
    public DateTime? CompletedOnUtc { get; private set; }
    
    public DateTime? CancelledOnUtc { get; private set; }

    public static Booking Reserve()
    {
        var booking = new Booking(Guid.NewGuid());
        booking.RaiseDomainEvents(new BookingReservedDomainEvent(booking.Id));
        return booking;
    }
}
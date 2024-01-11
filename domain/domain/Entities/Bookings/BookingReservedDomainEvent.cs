using domain.Abstractions;

namespace domain.Entities.Bookings;

public record BookingReservedDomainEvent(Guid bookingId): IDomainEvent;
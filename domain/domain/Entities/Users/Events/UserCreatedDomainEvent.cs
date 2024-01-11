using domain.Abstractions;

namespace domain.Entities.Users.Events;

public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent
{
    
}
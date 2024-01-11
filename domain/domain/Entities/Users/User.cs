using domain.Abstractions;
using domain.Entities.Users.Events;

namespace domain.Entities.Users;

public class User: Entity
{
    public FullName Name { get; private set; }
    public Email Email { get; private set; }
    private User(Guid id, FullName name, Email email) : base(id)
    {
        Name = name;
        Email = email;
    }

    public static User Create(FullName name, Email email)
    {
        var user = new User(Guid.NewGuid(), name, email);
        user.RaiseDomainEvents(new UserCreatedDomainEvent(user.Id));
        return user;
    }
}
using domain.Abstractions;

namespace domain.Entities;

public class Apartaments: Entity
{
    
    public Guid id { get; private set; } 
    public Name name { get; private set; }
    public Description description { get; private set; }
    public Address address { get; private set; }
    public Money price { get; private set; }
    public Apartaments(Guid id) : base(id)
    {
    }
}
using domain.Abstractions;

namespace domain.Entities;

public class Apartament: Entity
{
    
    public Guid id { get; private set; } 
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Address Address { get; private set; }
    public Money Price { get; private set; }
   
    public Apartament(Guid id, Name name, Description description, Address address,Money price) : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
    }
}
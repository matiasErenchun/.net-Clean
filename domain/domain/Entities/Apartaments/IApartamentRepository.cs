namespace domain.Entities.Apartaments;

public interface IApartamentRepository
{
    Task<Apartament?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
using ACME.Domain.Abstractions.Interfaces;

namespace ACME.Domain.Abstractions;

public class Entity
{
    
    protected Entity(long id)
    {
        Id = id;
    }
    public long Id { get; init; }

    public byte[]? Timestamp { get; set; }
}

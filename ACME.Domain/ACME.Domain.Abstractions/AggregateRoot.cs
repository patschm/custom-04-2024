using ACME.Domain.Abstractions.Interfaces;

namespace ACME.Domain.Abstractions;

public class AggregateRoot : Entity
{
    private readonly List<IDomainEvent> _events = new();
    protected AggregateRoot(long id): base(id) { }

    public List<IDomainEvent> DomainEvents { get => _events; }
    protected void Raise(IDomainEvent evt)
    {
        _events.Add(evt);
    }
}

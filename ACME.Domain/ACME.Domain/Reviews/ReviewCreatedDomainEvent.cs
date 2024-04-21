using ACME.Domain.Abstractions.Interfaces;

namespace ACME.Domain.Reviews.Reviews;

public record ReviewCreatedDomainEvent(long id) : IDomainEvent;

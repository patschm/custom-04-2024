using ACME.Domain.Abstractions.Interfaces;

namespace ACME.Domain.Reviews.Reviewers;

public record ReviewerCreatedDomainEvent(long Id) : IDomainEvent;

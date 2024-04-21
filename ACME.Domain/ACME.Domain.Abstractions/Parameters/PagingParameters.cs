namespace ACME.Domain.Abstractions.Parameters;

public record PagingParameters(int Page = 1, int Size = 10);

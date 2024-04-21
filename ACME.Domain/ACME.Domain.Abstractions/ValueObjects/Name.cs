namespace ACME.Domain.Abstractions.ValueObjects;

public record Name
{
    public Name(string? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(Name));
        Value = value;
    }

    public string? Value { get; set; }

    public static implicit operator Name(string? value) => new Name(value);
    public static implicit operator string(Name value) => value.Value ?? "";
}

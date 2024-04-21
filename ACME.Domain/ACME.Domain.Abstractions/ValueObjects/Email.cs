using System.Text.RegularExpressions;

namespace ACME.Domain.Abstractions.ValueObjects;
public record Email
{
    private const string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

    public Email(string? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(Email));
        if (!Regex.IsMatch(value, pattern))
        {
            throw new ArgumentException($"{value} is not valid.", nameof(Email));
        }
        Value = value;
    }

    public string? Value { get; set; }

    public static implicit operator Email(string? value) => new Email(value);
    public static implicit operator string(Email value) => value.Value ?? "";
}

using System.Text.RegularExpressions;

namespace ACME.Domain.Abstractions.ValueObjects;

public record Image
{
    private const string pattern = @"([\w|\s|-]+)\.(?:jp(e?)g|gif|png)";

    public Image(string? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(Image));
        if (!Regex.IsMatch(value, pattern))
        {
            throw new ArgumentException($"{value} is not valid.", nameof(Image));
        }
        Value = value;
    }

    public string? Value { get; set; }

    public static implicit operator Image(string? value) =>new Image(value);
    public static implicit operator string(Image value) => value.Value ?? "";
}

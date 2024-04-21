using System.Text.RegularExpressions;

namespace ACME.Domain.Abstractions.ValueObjects;

public record WebSite
{
    private const string pattern = @"[http(s)?:\/\/]?[(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)";

    public WebSite(string? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(WebSite));
        if (!Regex.IsMatch(value, pattern))
        {
            throw new ArgumentException($"{value} is not valid.", nameof(WebSite));
        }
        Value = value;
    }

    public string Value { get; init; }

    public static implicit operator WebSite(string? value) =>new WebSite(value);
    public static implicit operator string(WebSite value) => value.Value ?? "";
}

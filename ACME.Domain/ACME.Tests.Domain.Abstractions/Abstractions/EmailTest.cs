using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Tests.Domain.Abstractions;

public class EmailTest
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Email_Should_Throw_ArgumentException(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new Email(value));
    }

    [Theory]
    [InlineData("karel")]
    [InlineData("@")]
    [InlineData("k@test.")]
    public void Email_Should_Not_Be_Valid(string? value)
    {
        var exception = Assert.Throws<ArgumentException>(() => new Email(value));

        Assert.NotEmpty(exception.Message);
    }
    [Theory]
    [InlineData("karel@test.nl")]
    [InlineData("k@test.test.nl")]
    public void Email_Should_Be_Valid(string? value)
    {
        Assert.IsType<Email>(new Email(value));
    }
}
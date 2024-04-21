using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Tests.Domain.Abstractions;

public class NameTest
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Name_Should_Throw_ArgumentException(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new Name(value));
    }

    [Fact]
    public void Name_Should_Be_Valid()
    {
        string value = "Hans";
        Name name = new Name(value);

        Assert.Equal(value, name.Value);
    }
}
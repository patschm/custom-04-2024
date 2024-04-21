using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Tests.Domain.Abstractions;

public class ImageTest
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Image_Should_Throw_ArgumentException(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new Image(value));
    }

    [Theory]
    [InlineData("//.jpg")]
    [InlineData(".jpg")]
    public void Image_Should_Not_Be_Valid(string? value)
    {
        var exception = Assert.ThrowsAny<ArgumentException>(() => new Image(value));

        Assert.NotEmpty(exception.Message);
    }
    [Theory]
    [InlineData("img.jpg")]
    [InlineData("img.jpeg")]
    [InlineData("img.png")]
    [InlineData("img.gif")]
    public void Image_Should_Be_Valid(string? value)
    {
        Assert.IsType<Image>(new Image(value));
    }
}
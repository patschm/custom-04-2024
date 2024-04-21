using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Tests.Domain.Abstractions;

public class WebSiteTest
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void WebSite_Should_Throw_ArgumentException(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new WebSite(value));
    }

    [Theory]
    //[InlineData("wwww.test.com")]
    //[InlineData("www.test.commmmm")]
    //[InlineData("www.test.c")]
    [InlineData("www..c")]
    //[InlineData("htp://www.test.com")]
    //[InlineData("blah://www.test.com")]
    public void WebSite_Should_Not_Be_Valid(string? value)
    {
        var exception = Assert.ThrowsAny<ArgumentException>(() => new WebSite(value));

        Assert.NotEmpty(exception.Message);
    }
    [Theory]
    [InlineData("www.test.nl")]
    [InlineData("https://www.test.nl")]
    public void Website_Should_Be_Valid(string? value)
    {
        Assert.IsType<WebSite>(new WebSite(value));
    }
}
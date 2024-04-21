using ACME.Domain.Reviews.Reviews;

namespace ACME.Tests.Domain.Reviews;

public class ScoreTest
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(6)]
    public void Score_Should_Throw_ArgumentOutOfRangeException(int value)
    {
        Assert.ThrowsAny<ArgumentOutOfRangeException>(() => new Score(value));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void Score_Should_Be_Valid(int value)
    {
        var score = new Score(value);

        Assert.Equal(value, score.Value);
    }
   
}
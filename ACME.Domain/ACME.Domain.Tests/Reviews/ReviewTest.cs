using ACME.Domain.Reviews.Reviews;

namespace ACME.Tests.Domain.Reviews;

public class ReviewTest
{
    [Fact]
    public void Review_Should_Return_Object_When_Valid()
    {
        var score = new Score(3);

        var review = Review.Create(1, 1, 1, score, "text");

        Assert.NotNull(review);
        Assert.IsType<Review>(review);
    }

    [Fact]
    public void Review_Should_RaiseDomainEvent_When_Valid()
    {
        var score = new Score(3);

        var review = Review.Create(1, 1, 1, score, "text");

        Assert.NotEmpty(review.DomainEvents);
        Assert.Single(review.DomainEvents);
        Assert.Collection(review.DomainEvents, r => Assert.IsType<ReviewCreatedDomainEvent>(r));
    }
}

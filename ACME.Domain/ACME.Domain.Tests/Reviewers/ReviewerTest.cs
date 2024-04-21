using ACME.Domain.Abstractions.ValueObjects;
using ACME.Domain.Reviews.Reviewers;

namespace ACME.Tests.Domain.Reviews;

public class ReviewerTest
{
    [Fact]
    public void Reviewer_Should_Return_Object_When_Valid()
    {
        var name = new Name("First");
        var userName = new Name("User");
        var email = new Email("pre@post.com");

        var reviewer=Reviewer.Create(1, name, userName, email, "password");

        Assert.NotNull(reviewer);
        Assert.IsType<Reviewer>(reviewer);  
    }


}

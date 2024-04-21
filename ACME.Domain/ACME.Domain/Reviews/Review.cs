using ACME.Domain.Abstractions;

namespace ACME.Domain.Reviews.Reviews;

public class Review : AggregateRoot
{
    private Review(long id, long productId, long reviewerId, Score score, string? text) : base(id)
    {
        ProductId = productId;
        ReviewerId = reviewerId;
        Score = score;
        Text = text;
    }

    public string? Text { get; private set; }
    public Score Score { get; private set; }
    public long ProductId { get; private set; }
    public long ReviewerId { get; private set; }

    public static Review Create(long id, long productId, long reviewerId, Score score, string? text)
    {
        var review = new Review(id, productId, reviewerId, score, text);    
        review.Raise(new ReviewCreatedDomainEvent(review.Id));
        return review;
    }
}

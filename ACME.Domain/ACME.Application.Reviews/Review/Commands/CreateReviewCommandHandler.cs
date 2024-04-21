using ACME.Domain.Reviews.Repositories;
using MediatR;
using ProductReview = ACME.Domain.Reviews.Reviews.Review;

namespace ACME.Application.Reviews.Review.Commands;

public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
{
    private IReviewWriteRepository _repository;

    public CreateReviewCommandHandler(IReviewWriteRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        var review = ProductReview.Create(0, request.productId, request.reviewerId, request.Score, request.Text);
        await _repository.CreateAsync(review);
    }
}

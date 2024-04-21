using ACME.Domain.Reviews.Repositories;
using MediatR;
using ProductReview = ACME.Domain.Reviews.Reviews.Review;

namespace ACME.Application.Reviews.Queries;

public class GetReviewCommandHandler : IRequestHandler<GetReviewCommand, ProductReview>
{
    private readonly IReviewReadRepository _reviewReadRepository;

    public GetReviewCommandHandler(IReviewReadRepository reviewReadRepository)
    {
        _reviewReadRepository = reviewReadRepository;
    }

    public async Task<ProductReview> Handle(GetReviewCommand request, CancellationToken cancellationToken)
    {
        var product = await _reviewReadRepository.GetAsync(request.Id);
        return product;
    }
}

using ACME.Domain.Reviews.Repositories;
using MediatR;

using ProductReview = ACME.Domain.Reviews.Reviews.Review;

namespace ACME.Application.Reviews.Queries;

public record GetReviewsCommandHandler : IRequestHandler<GetReviewsCommand, IEnumerable<ProductReview>>
{
    private readonly IReviewReadRepository _reviewReadRepository;

    public GetReviewsCommandHandler(IReviewReadRepository reviewReadRepository)
    {
        _reviewReadRepository = reviewReadRepository;
    }

    public async Task<IEnumerable<ProductReview>> Handle(GetReviewsCommand request, CancellationToken cancellationToken)
    {
        return await _reviewReadRepository.GetAllAsync(request.Pager);
    }
}

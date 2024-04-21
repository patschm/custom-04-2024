using ACME.Domain.Abstractions.Parameters;
using MediatR;

using ProductReview = ACME.Domain.Reviews.Reviews.Review;

namespace ACME.Application.Reviews.Queries;

public record GetReviewsCommand(PagingParameters Pager): IRequest<IEnumerable<ProductReview>>;

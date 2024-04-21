using MediatR;
using ProductReview = ACME.Domain.Reviews.Reviews.Review;

namespace ACME.Application.Reviews.Queries;

public record GetReviewCommand(long Id): IRequest<ProductReview>;
